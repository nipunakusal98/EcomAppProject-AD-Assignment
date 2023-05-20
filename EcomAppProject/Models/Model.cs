using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }

        public string ModelName { get; set; }

        public string ModelPictureURL { get; set; }
 
        public string DefaultRAM { get; set; }
 
        public string DefaultVGA { get; set; }

        public string DefaultProcessor { get; set; }

        public string DefaultOS { get; set; }

        public string DefaultAntivirus { get; set; }
        
        public int DefaultModelPrice { get; set; }

        // Foreign key
        public int SeriesID { get; set; }
        public Series Series { get; set; }  // Navigation properties

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }

    }
}
