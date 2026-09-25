namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Managers
    {
        public Managers()
        {
            Teachers = new HashSet<Teachers>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int PositionId { get; set; }
        public Positions Positions { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
    }
}
