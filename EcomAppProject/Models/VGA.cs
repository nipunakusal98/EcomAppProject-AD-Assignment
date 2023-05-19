using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class VGA
    {
        [Key]
        public int VGAID { get; set; }
        public string VGADescription { get; set; }

        public string VGAPictureURL { get; set; }
        public int VGAPrice { get; set; }


        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }
    }
}
