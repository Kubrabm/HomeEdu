

namespace HomeEdu.DAL.Entities
{
    public class LatestPost
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public int DetailSidebarId { get; set; }
        public DetailSidebar DetailSidebar { get; set; }

    }
}
