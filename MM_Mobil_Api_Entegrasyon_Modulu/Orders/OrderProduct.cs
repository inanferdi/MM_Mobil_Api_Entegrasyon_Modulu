using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class OrderProduct
    {
        public string productId { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string imageURL { get; set; }
        public string variantOptionDisplay { get; set; }
        public string stockCode { get; set; }
        public string code { get; set; }
        public decimal vatRate { get; set; }
    }
}
