namespace HomeEdu.DAL.Entities
{
    public class GetInTouch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}
