using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class OrderStatusList
    {
        private int OrderNumber;
        private int Status;

        public OrderStatusList(int OrderNumber,int Status)
        {

            this.OrderNumber = OrderNumber;
            this.Status = Status;
        }

        public void UpdateOrderStatusList()
        {

            string url = "/order/updateOrderStatusList";

            var client = new Api.Client<HelperResponse>();

            var result = client.PutMethod(this, url);

            if (!result.success) throw new ArgumentException("Sipariş durum bilgisi güncellenemedi. " + result.message);
        }

        public int orderNumber { get { return this.OrderNumber; } set { this.OrderNumber = value; } }
        public int status { get { return this.Status; } set { this.Status = value; } }
    }
}
