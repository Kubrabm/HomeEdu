using HomeEdu.DAL.Entities;

namespace HomeEdu.ViewModels
{
    public class BlogViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<PageCount> PageCounts { get; set; }
    }
}
