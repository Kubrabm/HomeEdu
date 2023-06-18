
namespace HomeEdu.DAL.Entities
{
    public class Header
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<Navigation> Navigations { get; set; }
    }
}
