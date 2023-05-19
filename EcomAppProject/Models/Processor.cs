using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class Processor
    {
            [Key]
            public int ProcessorID { get; set; }

            [Display(Name = "Description")]
             public string ProcessorDescription { get; set; }

            [Display(Name ="Processor Picture")]
            public string ProcessorPictureURL { get; set; }

             [Display(Name = "Processor Price")]
             public int ProcessorPrice { get; set; }

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }


    }
}
