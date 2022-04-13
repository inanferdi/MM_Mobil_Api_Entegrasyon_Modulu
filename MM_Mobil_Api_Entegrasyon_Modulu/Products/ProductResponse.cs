using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Products
{
    public class ProductResponse
    {
        public string batchRequestId { get; set; }
        public DateTime creationDate { get; set; }
        public int totalCount { get; set; }
        public int failedCount { get; set; }
    }
}
