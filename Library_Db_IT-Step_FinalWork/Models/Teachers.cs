using System.ComponentModel.DataAnnotations;

namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Teachers
    {
        public Teachers()
        {
            Groups = new HashSet<Groups>();
            Subjects = new HashSet<Subjects>();
            Departments = new HashSet<Departments>();
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Patronymic { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Hiring { get; set; }
        public int CountryId { get; set; }
        public int PositionId { get; set; }
        public int? ManagersId { get; set; }
        public Managers Manager { get; set; }
        public Country Country { get; set; }
        public Positions Positions { get; set; }
        public ICollection<Departments> Departments { get; set; }
        public ICollection<Subjects> Subjects { get; set; }
        public ICollection<Groups> Groups { get; set; }
    }
}
