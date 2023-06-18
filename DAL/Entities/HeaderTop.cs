namespace HomeEdu.DAL.Entities
{
    public class HeaderTop 
    {
        public int Id { get; set; }
        public string Connection { get; set; }
        public ICollection<NavigationTop> TopNavigation { get; set; }
    }
}
