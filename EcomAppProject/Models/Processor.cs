using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class Processor
    {
            [Key]
            public int ProcessorID { get; set; }
            public string ProcessorDescription { get; set; }
            public string ProcessorPictureURL { get; set; }
            public int ProcessorPrice { get; set; }

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }


    }
}
