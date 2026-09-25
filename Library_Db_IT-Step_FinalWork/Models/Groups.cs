namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Groups
    {
        public Groups()
        {
            Teachers = new HashSet<Teachers>();
            Students = new HashSet<Students>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public ICollection<Students> Students { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
    }
}
