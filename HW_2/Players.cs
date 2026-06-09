
/// <summary>
/// Игроки
/// </summary>
public class Player
{
    public int PlayerId { get; set; }
    public int ClubId { get; set; }
    public string Name { get; set; }
    private int _goals;
    /// <summary>
    /// Число забитых голов не может быть орицательным
    /// </summary>
    public int Goals
    {
        get => _goals;
        set
        {
            if (value < 0) throw new ArgumentException("Число голов не может быть отрицательным");
            _goals = value;
        }
    }
    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="player_Id">ID игрока</param>
    /// <param name="club_Id">ID клуба</param>
    /// <param name="name">Имя игрока</param>
    /// <param name="goals">Число забитых голов</param>
    public Player(int player_Id, int club_Id, string name, int goals)
    {
        PlayerId = player_Id;
        ClubId = club_Id;
        Name = name;
        Goals = goals;
    }
    public Player() : this(0, 0, "", 0) { }

    public override string ToString()
    {
        return $"{PlayerId, -10} | {ClubId, 10} | {Name, 20} | {Goals, 10}";
    }
}