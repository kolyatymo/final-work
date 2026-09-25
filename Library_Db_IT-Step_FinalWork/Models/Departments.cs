using System.ComponentModel.DataAnnotations;

namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Departments
    {
        public Departments()
        {
            Students = new HashSet<Students>();
            Teachers = new HashSet<Teachers>();
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Building { get; set; }
        public ICollection<Students> Students { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
    }
}
