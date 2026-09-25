namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Students
    {
        public Students()
        {
            Subjects = new HashSet<Subjects>();
            Departments = new HashSet<Departments>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Rating { get; set; }
        public int GroupsId { get; set; }
        public Groups Groups { get; set; }
        public DateTime StudAdmission { get; set; }
        public ICollection<Departments> Departments { get; set; }
        public ICollection<Subjects> Subjects { get; set; }
    }
}
