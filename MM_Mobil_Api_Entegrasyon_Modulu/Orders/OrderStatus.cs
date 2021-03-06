using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class OrderStatus
    {
        private string OrderItemId;
        private int Status;
        private int TrakingNumber;
        private string TrakingUrl;
        private string CargoCompanyId;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="OrderItemId">Kargo statüsü güncellenecek ürünün id değerini iletileceği alandır.</param>
        /// <param name="Status">Kargoya verilen siparişin statüsünü güncellemek için kullanılacak alandır.</param>
        /// <param name="TrakingNumber">Kargo Takip numarasının girileceği alandır.</param>
        /// <param name="TrakingUrl">Kargo takip linkinin girileceği alandır. (Opsiyonel)</param>
        /// <param name="CargoCompanyId">Kargo firmasına ait bilgileri içeren alandır.</param>

        public OrderStatus(string OrderItemId,int Status,int TrakingNumber,
            string TrakingUrl="",string CargoCompanyId)
        {
            this.OrderItemId = OrderItemId;
            this.Status = Status;
            this.TrakingNumber = TrakingNumber;
            this.TrakingUrl = TrakingUrl;
            this.CargoCompanyId = CargoCompanyId;

        }

        public void UpdateOrderStatus()
        {

            string url = "/order/updateOrderStatus";

            var client = new Api.Client<HelperResponse>();

            var result = client.PostMethod(this, url);

            if (!result.success) throw new ArgumentException("Kargo durum bilgisi güncellenemedi. " + result.message);
        }

        public string orderitemid { get { return this.OrderItemId; } set { this.OrderItemId = value; } }
        public int status { get { return this.Status; } set { this.Status = value; } }
        public int trackingnumber { get { return this.TrakingNumber; } set { this.TrakingNumber = value; } }
        public string trackingurl { get { return this.TrakingUrl; } set { this.TrakingUrl = value; } }
        public string cargoCompanyId { get { return this.CargoCompanyId; } set { this.CargoCompanyId = value; } }
    }
}
