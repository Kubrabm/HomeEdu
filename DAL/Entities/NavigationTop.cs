namespace HomeEdu.DAL.Entities
{
    public class NavigationTop
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int HeaderTopId { get; set; }
        public HeaderTop HeaderTop { get; set; }

    }
}
