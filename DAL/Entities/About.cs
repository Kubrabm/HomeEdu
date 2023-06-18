
namespace HomeEdu.DAL.Entities
{
    public class About
    {
        public int Id { get; set; } 
        public string Tittle { get; set; }
        public string BgImgUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<AboutBanner> AboutBanners { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Testimonial> Testimonials { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<NoticeRight> NoticeRights { get; set; }


    }
}
