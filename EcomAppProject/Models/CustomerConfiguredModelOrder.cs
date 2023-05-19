using EcomAppProject.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomAppProject.Models
{
    public class CustomerConfiguredModelOrder
    {
        [Key]
        public int CustomerConfiguredModelOrderID { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        public int ConfigurationPrice { get; set; }
        //public bool IsCustomized { get; set; }


        // Foreign keys
        public int CustomerConfigID { get; set; }
        [ForeignKey("CustomerConfigID")]

       


        // Navigation properties
        public CustomerConfiguration CustomerConfiguration { get; set; }


        public List<CustomerConfiguredModelPayment> CustomerConfiguredModelPayment { get; set; }

    }
}
