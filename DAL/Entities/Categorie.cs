namespace HomeEdu.DAL.Entities
{
    public class Categorie 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DetailSidebarId { get; set; }
        public DetailSidebar DetailSidebar { get; set; }
    }
}
