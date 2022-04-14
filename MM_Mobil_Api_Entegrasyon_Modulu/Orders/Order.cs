using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class Order
    {
        public string orderId { get; set; }
        public int orderNumber { get; set; }
        public DateTime orderDate { get; set; }
        public decimal orderAmount { get; set; }
        public decimal shipmentAmount { get; set; }
        public decimal discountAmount { get; set; }
        public string discountDescription { get; set; }
        public string currency { get; set; }
        public int paymentType { get; set; }
        public int orderStatus { get; set; }
        public string customerId { get; set; }
        public string customerIdentificationNumber { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
    }

}
