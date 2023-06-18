namespace HomeEdu.DAL.Entities
{
    public class Subscribe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Alert> Alerts { get; set; }
    }
}
