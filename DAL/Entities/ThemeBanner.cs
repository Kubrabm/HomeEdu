namespace HomeEdu.DAL.Entities
{
    public class ThemeBanner
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public int DetailSidebarId { get; set; }
        public DetailSidebar DetailSidebar { get; set; }
    }
}
