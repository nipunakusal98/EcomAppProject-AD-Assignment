using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class Memory
    {
        [Key]
        public int MemoryID { get; set; }
        public string MemoryDescription { get; set; }
        public string MemoryPictureURL { get; set; }
        public int MemoryPrice { get; set; }

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }

    }
}
