using System.ComponentModel.DataAnnotations;

namespace KisiselWebProjesi.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int id { get; set; }
        public string profil { get; set; }
        public string name { get; set; }
        public string title { get; set;}
        public string explanation { get; set; }
        public string communication { get; set; }

    }
}