namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Country
    {
        public Country()
        {
            Teachers = new HashSet<Teachers>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
    }
}
