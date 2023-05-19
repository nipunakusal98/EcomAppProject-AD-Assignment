using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomAppProject.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

        // Foreign key
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]

        // Navigation properties
        public Order Order { get; set; }

    }
}
