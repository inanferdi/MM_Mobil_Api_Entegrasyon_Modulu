using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Teslimat
{
    public class StoreDelivery
    {
        /// <summary>
        /// Teslimat tipinin id değerini belirtmektedir.
        /// </summary>
        public string deliveryId { get; set; }
        /// <summary>
        /// Kargo firmasının adını belirtmektedir. 
        /// </summary>
        public decimal price
        {
            get
            {
                return this.price;
            }

            set
            {
                value = Convert.ToDecimal(value);
            }
        }
        public List<StoreAddress> storeAddressList { get; set; }
    }
}
