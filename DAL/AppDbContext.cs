
using HomeEdu.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace HomeEdu.DAL
{
    public class AppDbContext:DbContext
    {
        internal readonly object Information;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Header> Header { get; set; }
        public DbSet<Navigation> Navigation { get; set; }
        public DbSet<HeaderTop> HeaderTop { get; set; }
        public DbSet<NavigationTop> NavigationTop { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<UsefulLink> UsefulLink { get; set; }
        public DbSet<GetInTouch> GetInTouch { get; set; }
        public DbSet<DetailSidebar> DetailSidebar { get; set; }
        public DbSet<Categorie> Categori { get; set; }
        public DbSet<ThemeBanner> ThemeBanner { get; set; }
        public DbSet<LatestPost> LatestPost { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Reply> Reply { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<Alert> Alert { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<AboutBanner> AboutBanner { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<NoticeRight> NoticeRight { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<NoticeLeft> NoticeLeft { get; set; }
        public DbSet<PageCount> PageCount { get; set; }
        public DbSet<Slider> Slider { get; set; }



    }
}
