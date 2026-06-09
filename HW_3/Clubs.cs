using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Homework3.HW_3
{
    /// <summary>
    /// Футбольные клубы
    /// </summary>
    public class Club
    {
        /// <summary>
        /// ID клуба
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Имя клуба
        /// </summary>
        [Required]
        public string Name { get; set; }

        public ICollection<Player> Players
        { get; set; } = new List<Player>();

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="club_id">ID клуба</param>
        /// <param name="club_name">Имя клуба</param>
        public Club(string club_name)
        {
            Name = club_name;
        }
        /// <summary>
        /// Конструктор по умоллчанию
        /// </summary>
        public Club() : this("") { }
        public override string ToString()
        {
            return $"{Id,-10} | {Name,15}";
        }
    }
}