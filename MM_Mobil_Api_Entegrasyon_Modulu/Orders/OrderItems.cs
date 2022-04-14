using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class OrderItems
    {
        public string orderItemId { get; set; }
        public int orderItemStatus { get; set; }
        public int deliveryType { get; set; }
        public int quantity { get; set; }
        public string shipmentCode { get; set; }
        public Order_ListPrice listPrice { get; set; }
        public Order_ListPrice salePrice { get; set; }
        public Order_ListPrice taxAmount { get; set; }
        public Order_ListPrice shipmentAmount { get; set; }
        public Order_ListPrice discountAmount { get; set; }
        public string discountDescription { get; set; }
        public Order_ListPrice totalPrice { get; set; }
        public bool taxIncluded { get; set; }
        public OrderCargo cargo { get; set; }
        public OrderProduct product { get; set; }

    }
}
