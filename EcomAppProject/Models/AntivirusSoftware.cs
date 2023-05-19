using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class AntivirusSoftware
    {
        [Key]
        public int AntivirusID { get; set; }
        public string AntivirusDescription { get; set; }
        public int AntivirusPrice { get; set; }

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }
    }
}
