using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class OrderList
    {
        public Order order { get; set; }
        public ShipmentAddress shipmentAddress { get; set; }
        public BillingAddress billingAddress { get; set; }
        public List<OrderItems> items { get; set; }


        public List<OrderList> GetOrdersForApi(DateTime startDate,DateTime endDate)
        {

            var data = new OrderResponse();
            data.startDate = startDate.ToString("yyyy-MM-dd");
            data.endDate = endDate.ToString("yyyy-MM-dd");

            string url = "/order/getOrdersForApi";

            var client = new Api.Client<OrderList>();

            var result = client.PostMethodList(data, url);

            return result;
        }

    }

     class OrderResponse
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
    }
}
