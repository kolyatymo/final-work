using System.ComponentModel.DataAnnotations;

namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Subjects
    {
        public Subjects()
        {
            Students = new HashSet<Students>();
            Teachers = new HashSet<Teachers>();
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
        public ICollection<Students> Students { get; set; }
    }
}
