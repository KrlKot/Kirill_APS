using System;
using System.Data;
using System.IO;
using System.Text;

class Program 
{
    static void Main(string[] args) 
    {
        string dbPath = "Data Source=football.db";
        string ClubsPath = Path.Combine(AppContext.BaseDirectory, "Football_Clubs.csv");
        string PlayersPath = Path.Combine(AppContext.BaseDirectory, "Players.csv");
        var db = new DatabaseManager(dbPath);
        db.InitializeDatabase(ClubsPath, PlayersPath);
        string command;
        do
        {
            ShowMenu();
            command = Console.ReadLine();
            switch (command)
            {
                case "1": ShowAllClubs(db); break;
                case "2": ShowAllPlayers(db); break;
                case "3": AddPlayer(db); break;
                case "4": UpdatePlayer(db); break;
                case "5": DeletePlayer(db); break;
                case "6": Data(db); break;
                case "0": Console.WriteLine("Выход из программы"); break;
                default: Console.WriteLine("Неверный ввод"); break;
            };
        } while (command != "0");
    }
    static void ShowMenu() 
    {
        Console.WriteLine("=== Управление данными ===");
        Console.WriteLine("1 - Показать все футбольные клубы");
        Console.WriteLine("2 - Показать всех игроков");
        Console.WriteLine("3 - Добавить игрока");
        Console.WriteLine("4 - Редактировать игрока");
        Console.WriteLine("5 - Удалить игрока");
        Console.WriteLine("6 - Отчёт");
        Console.WriteLine("0 - Выход");
        Console.Write("Ввод: ");
    }
    static void ShowAllClubs(DatabaseManager db) 
    {
        List<Club> clubs = db.GetAllClubs();
        Console.WriteLine($"{" ID клуба", -10} | {"Имя клуба", 15}");
        Console.WriteLine("-----------+------------------");
        foreach (Club _club in clubs) Console.WriteLine(_club.ToString());
    }
    static void ShowAllPlayers(DatabaseManager db)
    {
        List<Player> players = db.GetAllPlayers();
        Console.WriteLine($"{" ID игрока", -10} | {"ID клуба", 10} | {"Имя игрока", 20} | {"Число голов", 10}");
        Console.WriteLine("-----------+------------+----------------------+------------");
        foreach (Player _player in players) Console.WriteLine(_player.ToString());
    }
    static void AddPlayer(DatabaseManager db)
    {
        try
        {
            Console.WriteLine("Список доступных клубов:");
            ShowAllClubs(db);
            Console.WriteLine("Введите ID клуба нового игрока: ");

            int clubId = int.Parse(Console.ReadLine());
            while (true) 
            {
                bool f = false;
                foreach (Club club in db.GetAllClubs()) 
                {
                    if (club.Id == clubId) f= true;
                }
                if (f) break;
                Console.WriteLine("Введенный ID не соответствует ни одному существующему. Введиие один из предложенных ID");
                clubId = int.Parse(Console.ReadLine());
            }

            Console.Write("Введите имя игрока: ");
            string name;
            do
            {
                name = Console.ReadLine();
                if (name == "") Console.WriteLine("Имя игрока не может быть пустым введи его заново");
            } while (name == "");
            Console.Write("Введите количество забитых голов: ");
            int goals = int.Parse(Console.ReadLine());

            Player player = new Player(0, clubId, name, goals);
            db.AddPlayer(player);
            Console.WriteLine("Игрок добавлен");
        }
        catch (Exception ex) { Console.WriteLine($"Ошибка при добавлении игрока {ex.Message}"); }
    }
    static void UpdatePlayer(DatabaseManager db) 
    {
        try
        {
            Console.WriteLine("Введите ID игрока данные которого хотите изменить: ");
            ShowAllPlayers(db);
            int id = int.Parse(Console.ReadLine());
            Player player = db.GetPlayer(id);
            sConsole.WriteLine(player.ToString());

            Console.WriteLine("Введите новый ID клуба: ");
            id = int.Parse(Console.ReadLine());
            player.ClubId = id;

            Console.WriteLine("Введите новое имя игрока: ");
            string name = Console.ReadLine();
            player.Name = name;

            Console.WriteLine("Введите число голов: ");
            int goals = int.Parse(Console.ReadLine());
            player.Goals = goals;

            db.UpdatePlayer(player);
        }
        catch (NullReferenceException ex) { Console.WriteLine(ex.ToString()); }
    }
    static void DeletePlayer(DatabaseManager db) 
    {
        Console.WriteLine("Введите ID игрока которого хотите удалить");
        ShowAllPlayers(db);
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine($"Вы уверены что хотите удалить игрока {db.GetPlayer(id).ToString()} (y/n)?");
        string ans = Console.ReadLine();
        switch (ans)
        {
            case "y": db.DeletePlayer(id); break;
            case "n": Console.WriteLine("Удаление отмменено"); break;
            default: Console.WriteLine("Неверная команда"); break;
        }
    }
    static void Data(DatabaseManager db) 
    {
        Console.WriteLine("Выберите нужный отчёт:");
        Console.WriteLine("1 - Полный список игроков и вся информация о них");
        Console.WriteLine("2 - Количество игроков в каждом клубе");
        Console.WriteLine("3 - Среднее число голов для каждого клуба");
        string ans = Console.ReadLine();
        switch (ans) 
        {
            case "1": new ReportBuilder(db).
                    Query("SELECT Football_Clubs.club_name, Players.player_name, Players.goals FROM Players INNER JOIN Football_Clubs ON Players.club_id = Football_Clubs.club_id").
                    Title("Полный отчёт об игроках").
                    Header("Имя клуба", "Имя игрока", "Голы").
                    ColumnWidths(20, 20, 5).
                    Print(); break;

            case "2": new ReportBuilder(db).
                    Query("SELECT Football_Clubs.club_name, COUNT(*) AS cnt FROM Players JOIN Football_Clubs ON Players.club_id = Football_Clubs.club_id GROUP BY Football_Clubs.club_name").
                    Title("Количетсво Игроков по клубам").
                    Header("Имя клуба", "Количество игроков").
                    ColumnWidths(20, 20).
                    Print(); break;

            case "3": new ReportBuilder(db).
                    Query("SELECT Football_Clubs.club_name, ROUND(AVG(Players.goals), 2) AS avg FROM Football_Clubs LEFT JOIN Players ON Players.club_id = Football_Clubs.club_id GROUP BY Football_Clubs.club_name").
                    Title("Среднее число голов по клубам").
                    Header("Имя клуба", "Среднее число голов").
                    ColumnWidths(20, 20).
                    Print(); break;
            default: Console.WriteLine("Неверная команда"); break;
        }
    }
}