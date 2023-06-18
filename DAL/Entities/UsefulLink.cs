namespace HomeEdu.DAL.Entities
{
    public class UsefulLink
    {
        public int Id { get; set; }
        public string FlagUrl { get; set; }
        public string Name { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}
