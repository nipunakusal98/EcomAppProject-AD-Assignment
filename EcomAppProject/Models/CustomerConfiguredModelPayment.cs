using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EcomAppProject.Data.Enums;

namespace EcomAppProject.Models
{
    public class CustomerConfiguredModelPayment
    {
        [Key]
        public int CustomerConfiguredModelPaymentID { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Foreign key
        public int CustomerConfiguredModelOrderID { get; set; }
        [ForeignKey("CustomerConfiguredModelOrderID")]

        

        // Navigation properties
        public CustomerConfiguredModelOrder CustomerConfiguredModelOrder { get; set; }
    }
}
