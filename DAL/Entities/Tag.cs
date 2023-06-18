namespace HomeEdu.DAL.Entities
{
    public class Tag
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int DetailSidebarId { get; set; }
        public DetailSidebar DetailSidebar { get; set; }
    }
}
