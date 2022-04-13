using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Teslimat
{
    public class CargoCompany
    {
        /// <summary>
        /// Teslimat tipinin id değerini belirtmektedir.
        /// </summary>
        public string deliveryId { get; set; }
        /// <summary>
        /// Kargo firmasının adını belirtmektedir. 
        /// </summary>
        public string cargoCompanyId { get; set; }
        /// <summary>
        /// Teslimat ücretini belirtmektedir.
        /// </summary>
        public decimal price
        {
            get { return this.price; }

            set
            {
                value = Convert.ToDecimal(value);
            }
        }
        /// <summary>
        /// Kampanyalı teslimat fiyatını belirtmektedir. 
        /// </summary>
        public decimal campaignPrice
        {
            get { return this.campaignPrice; }

            set
            {
                value = Convert.ToDecimal(value);
            }
        }
        /// <summary>
        ///  Kampanyalı fiyattan yararlanabilmek için kampanyalı teslimata ait limit fiyatı belirtmektedir.
        /// </summary>

        public decimal campaignAmount
        {
            get { return this.campaignAmount; }

            set
            {
                value = Convert.ToDecimal(value);
            }
        }
        /// <summary>
        /// Kampanyaya ait metni belirtmektedir.
        /// </summary>
        public string campaignText { get; set; }

    }
}
