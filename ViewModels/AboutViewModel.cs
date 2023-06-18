using HomeEdu.DAL.Entities;

namespace HomeEdu.ViewModels
{
    public class AboutViewModel
    {
        public List<AboutBanner> AboutBanners { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Video> Videos { get; set; }
        public List<NoticeLeft> NoticeLefts { get; set; }
    }
}
