namespace Library_Db_IT_Step_FinalWork.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PositionId { get; set; }
        public Positions Positions { get; set; }
    }
}
