
namespace HomeEdu.DAL.Entities
{
    public class Footer
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public string Description { get; set; }
        public string Copyright { get; set; }
        public ICollection<SocialMedia> SosialMedias { get; set; }
        public ICollection<Information> Informations { get; set; }
        public ICollection<UsefulLink> usefulLinks { get; set; }
        public ICollection<GetInTouch> GetInTouches { get; set; }

    }
}
