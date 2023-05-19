using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomAppProject.Models
{
    public class CustomerConfiguration
    {
        [Key]
        public int CustomerConfigID { get; set; }

        // Foreign keys
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public int ModelID { get; set; }
        [ForeignKey("ModelID")]
        public int ProcessorID { get; set; }
        [ForeignKey("ProcessorID")]
        public int MemoryID { get; set; }
        [ForeignKey("MemoryID")]
        public int VGAID { get; set; }
        [ForeignKey("MemoryID")]
        public int AntivirusID { get; set; }
        [ForeignKey("AntivirusID")]

        public int ConfigurationPrice { get; set; }
        //public bool IsCustomized { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public Model Model { get; set; }
        public Processor Processor { get; set; }
        public Memory Memory { get; set; }
        public VGA VGA { get; set; }
        public AntivirusSoftware Antivirus { get; set; }

    }
}
