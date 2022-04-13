using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Teslimat
{
    public class TeslimatTip
    {
        public CargoCompany cargoCompany { get; set; }
        public CargoCompany fastDelivery { get; set; }
        public StoreDelivery storeDelivery { get; set; }

        public TeslimatTip GetTeslimatTip()
        {

            string url = "http://%7Bbaseurl%7D/sellerRegister/getSellerDelivery";

            var client = new Api.Client<TeslimatTip>();

            return client.GetMethod(url);
        }
    }
}
