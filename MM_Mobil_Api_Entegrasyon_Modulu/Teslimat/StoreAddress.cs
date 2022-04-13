using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Teslimat
{
    public class StoreAddress
    {
        /// <summary>
        /// Mağazadan teslimat tipi için teslimat mağaza adını belirtmektedir.
        /// </summary>
        public string storeName { get; set; }
        /// <summary>
        /// Teslimat yapılacak şehir bilgisini içermektedir.Herhangi bir değer girilmezise,tüm şehirleri kapsamaktadır.
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// Mağazadan teslimat için ilgili mağazanın adres bilgisini içermektedir.
        /// </summary>
        public string addressDetail { get; set; }
    }
}
