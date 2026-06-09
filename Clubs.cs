
    /// <summary>
    /// Футбольные клубы
    /// </summary>
    public class Club
    {
        /// <summary>
        /// ID клуба
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя клуба
        /// </summary>
        public string Name { get; set; }

    public Player Player
    {
        get => default;
        set
        {
        }
    }

    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="club_id">ID клуба</param>
    /// <param name="club_name">Имя клуба</param>
    public Club(int club_id, string club_name) 
        {
            Id = club_id;
            Name = club_name;
        }
        /// <summary>
        /// Конструктор по умоллчанию
        /// </summary>
        public Club():this(0, "") { }
        public override string ToString()
        {
            return $"{Id, -10} | {Name, 15}";
        }
    }