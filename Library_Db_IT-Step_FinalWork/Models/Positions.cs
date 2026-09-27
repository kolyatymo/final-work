namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Positions
    {
        public Positions()
        {
            Teachers = new HashSet<Teachers>();
            Managers = new HashSet<Managers>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DirectorId { get; set; }
        public Director Director { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
        public ICollection<Managers> Managers { get; set; }
    }
}
