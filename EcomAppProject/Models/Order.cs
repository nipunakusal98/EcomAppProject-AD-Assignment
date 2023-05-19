using EcomAppProject.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomAppProject.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public string OrderStatus { get; set; }

        // Foreign keys
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        //public int CustomerConfigID { get; set; }
        //[ForeignKey("CustomerConfigID")]

        public int ModelID { get; set; }
        [ForeignKey("ModelID")]


        // Navigation properties
        public Model Model { get; set; }
        //public CustomerConfiguration CustomerConfiguration { get; set; }
        public Customer Customer { get; set; }
        //public CustomerConfiguration CustomerConfiguration { get; set; }
        public List<Payment> Payments { get; set; }

    }
}
