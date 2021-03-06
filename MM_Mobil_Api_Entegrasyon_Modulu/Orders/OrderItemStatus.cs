using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class OrderItemStatus
    {
        private int OrderNumber;
        private ItemStatus Item;

        public OrderItemStatus(int OrderNumber,ItemStatus Item)
        {
            this.OrderNumber = OrderNumber;
            this.Item = Item;
        }

        public void UpdateOrderItemStatus()
        {

            string url = "/order/updateOrderStatus";

            var client = new Api.Client<HelperResponse>();

            var result = client.PutMethod(this, url);

            if (!result.success) throw new ArgumentException("Ürün durum bilgisi güncellenemedi. " + result.message);
        }

        public int orderNumber { get { return this.OrderNumber; } set { this.OrderNumber = value; } }
        public ItemStatus item { get { return this.item; } set { this.item = value; } }
    }

    public class ItemStatus
    {

        private string OrderItemId;
        private int Status;

        public ItemStatus(string OrderItemId,int Status)
        {
            this.OrderItemId = OrderItemId;
            this.Status = Status;
        }

        public string orderItemId { get { return this.orderItemId; } set { this.orderItemId = value; } }
        public int status { get { return this.Status; } set { this.Status = value; } }
    }
}
