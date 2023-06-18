
namespace HomeEdu.DAL.Entities
{
    public class Alert 
    {
        public int Id { get; set; }
        public int SubscribeId { get; set; }
        public Subscribe Subscribe { get; set; }

    }
}
