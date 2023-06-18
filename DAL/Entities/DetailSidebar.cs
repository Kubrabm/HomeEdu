

namespace HomeEdu.DAL.Entities
{
    public class DetailSidebar 
    {
        public int Id { get; set; }
        public ICollection<Categorie> Categories { get; set; }
        public ICollection<ThemeBanner> ThemeBanner { get; set; }
        public ICollection<LatestPost> letstPosts { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }
}
