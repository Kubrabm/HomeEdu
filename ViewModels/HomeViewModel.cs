using HomeEdu.DAL.Entities;

namespace HomeEdu.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<NoticeLeft> NoticeLefts { get; set; }
        public List<NoticeRight> NoticeRights { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
