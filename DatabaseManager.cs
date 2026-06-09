using System;
using Microsoft.Data.Sqlite;
using System.IO;

public class DatabaseManager
{
	private string _connectionString;
	public DatabaseManager(string connectionString) {  _connectionString = connectionString; }
	private void CreateTables() 
	{
		using var con = new SqliteConnection(_connectionString);
		con.Open();
		var cmd = con.CreateCommand();
		cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Football_Clubs 
		(
		club_id INTEGER PRIMARY KEY AUTOINCREMENT,
		club_name TEXT NOT NULL
		);
		CREATE TABLE IF NOT EXISTS Players
		(
		player_id INTEGER PRIMARY KEY AUTOINCREMENT,
		club_id INTEGER NOT NULL,
		player_name TEXT NOT NULL,
		goals INTEGER NOT NULL,
		FOREIGN KEY (club_id) REFERENCES Football_Clubs(club_id)
		)";
		cmd.ExecuteNonQuery();
	}
	private void ImportClubsFromCsv(string path) 
	{
		using var con = new SqliteConnection(_connectionString);
		con.Open();
		string[] lines = File.ReadAllLines(path);
		for (int i = 1; i < lines.Length; i++)
		{
			string[] lineData = lines[i].Split(';');
			var cmd = con.CreateCommand();
			cmd.CommandText = "INSERT INTO Football_Clubs (club_id, club_name) VALUES (@id, @name)";
			var id = int.Parse(lineData[0]);
			var name = lineData[1];
			cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
		}
    }
    private void ImportPlayersFromCsv(string path)
    {
        using var con = new SqliteConnection(_connectionString);
        con.Open();
        string[] lines = File.ReadAllLines(path);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] lineData = lines[i].Split(';');
            var cmd = con.CreateCommand();
            cmd.CommandText = @"INSERT INTO Players 
			(player_id, club_id, player_name, goals)
			VALUES
			(@idPlayer, @idClub, @name, @goals)";
            var idPlayer = int.Parse(lineData[0]);
			var idClub = int.Parse(lineData[1]);
            var name = lineData[2];
			var goals = int.Parse(lineData[3]);

			cmd.Parameters.AddWithValue("@idPlayer", idPlayer);
            cmd.Parameters.AddWithValue("@idClub", idClub);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@goals", goals);

            cmd.ExecuteNonQuery();
        }
    }

	public void InitializeDatabase(string clubsPath, string playersPath) 
	{
		CreateTables();

		var clubs = GetAllClubs();
		if (clubs.Count == 0 && File.Exists(clubsPath))
		{
			ImportClubsFromCsv(clubsPath);
			Console.WriteLine($"Данные о футбольных клубах загружены из {clubsPath}");
		}

		var players = GetAllPlayers();
		if (players.Count == 0 && File.Exists(playersPath)) 
		{
			ImportPlayersFromCsv(playersPath);
			Console.WriteLine($"Данные об игроках загружены из {playersPath}");
		}
	}

	public (string[] columns, List<string[]> rows) ExecuteQuery(string sql) 
	{
		using var con = new SqliteConnection(_connectionString);
		con.Open();
		var cmd = con.CreateCommand();
		cmd.CommandText = sql;

		using var data = cmd.ExecuteReader();

		string[] columns = new string[data.FieldCount];
		for (int i = 0; i < columns.Length; i++) columns[i] = data.GetName(i);

		List<string[]> rows = new List<string[]>();
		while (data.Read()) 
		{
			string[] current = new string[data.FieldCount];
			for (int i = 0; i < current.Length; i++) current[i] = data.GetValue(i)?.ToString() ?? "";
			rows.Add(current);
		}
		return (columns, rows);
	}

	public List<Club> GetAllClubs() 
	{
		using var con = new SqliteConnection(_connectionString);
		con.Open();
		List <Club> clubs = new List<Club>();
		var cmd = con.CreateCommand();
		cmd.CommandText = "SELECT club_id, club_name FROM Football_Clubs";
		using var Data = cmd.ExecuteReader();
		while (Data.Read())
		{
			int id = Data.GetInt32(0);
			string name = Data.GetString(1);
			clubs.Add(new Club(id, name));
		}
		return clubs;
	}

	public List<Player> GetAllPlayers()
	{
		using var con = new SqliteConnection(_connectionString);
		con.Open();
		List<Player> players = new List<Player>();
		var cmd = con.CreateCommand();
		cmd.CommandText = "SELECT player_id, club_id, player_name, goals FROM Players";
		using var Data = cmd.ExecuteReader();
		while (Data.Read())
		{
			int idPlayer = Data.GetInt32(0);
			int idClub = Data.GetInt32(1);
			string name = Data.GetString(2);
			int goals = Data.GetInt32(3);
			players.Add(new Player(idPlayer, idClub, name, goals));
		}
		return players;
	}

    #region Players Usage
    public void AddPlayer(Player player) 
	{
		using var con = new SqliteConnection(_connectionString);
		con.Open();
		var cmd = con.CreateCommand();
		cmd.CommandText = "INSERT INTO Players (club_id, player_name, goals) VALUES (@id, @name, @goals)";
		cmd.Parameters.AddWithValue("@id", player.ClubId);
        cmd.Parameters.AddWithValue("@name", player.Name);
        cmd.Parameters.AddWithValue("@goals", player.Goals);
        cmd.ExecuteNonQuery();
    }

	public void UpdatePlayer(Player player) 
	{
        using var con = new SqliteConnection(_connectionString);
        con.Open();
        var cmd = con.CreateCommand();
		cmd.CommandText = @"UPDATE Players SET club_id = @clubId, player_name = @name, goals = @goals
		WHERE player_id = @id";
		cmd.Parameters.AddWithValue("@clubId", player.ClubId);
        cmd.Parameters.AddWithValue("@name", player.Name);
        cmd.Parameters.AddWithValue("@goals", player.Goals);
        cmd.Parameters.AddWithValue("@id", player.PlayerId);
		cmd.ExecuteNonQuery();
    }

	public void DeletePlayer(int id) 
	{
        using var con = new SqliteConnection(_connectionString);
        con.Open();
        var cmd = con.CreateCommand();
		cmd.CommandText = "DELETE FROM Players WHERE player_id = @id";
		cmd.Parameters.AddWithValue("@id", id);
		cmd.ExecuteNonQuery();
    }

	public Player GetPlayer(int id)
	{
		using var con = new SqliteConnection(_connectionString);
		con.Open();
		var cmd = con.CreateCommand();
		cmd.CommandText = "SELECT player_id, club_id, player_name, goals FROM Players WHERE player_id = @id";
		cmd.Parameters.AddWithValue("@id", id);
        var Data = cmd.ExecuteReader();
		if (Data.Read())return new Player(Data.GetInt32(0), Data.GetInt32(1), Data.GetString(2), Data.GetInt32(3));
		return null;
    }
    #endregion

}
