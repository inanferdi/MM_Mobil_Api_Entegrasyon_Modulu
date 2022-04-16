using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class RefundList
    {
        public int id { get; set; }
        public string refundId { get; set; }
        public long orderNumber { get; set; }
        public DateTime orderDate { get; set; }
        public long refundNumber { get; set; }
        public string refundType { get; set; }
        public int refundStatus { get; set; }
        public string refundStatusName { get; set; }
        public string shipmentCode { get; set; }
        public string paymentType { get; set; }
        public DateTime refundDate { get; set; }
        public RefundAmount totalAmount { get; set; }
        public RefundAmount refundAmount { get; set; }
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public string customerPhoneNumber { get; set; }
        public string customerAddress { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public string productStockCode { get; set; }
        public string shipmentCompanyName { get; set; }
        public string description { get; set; }
    }
}
