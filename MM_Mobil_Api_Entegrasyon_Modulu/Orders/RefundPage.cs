using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class RefundPage
    {
        public int pageSize { get; set; }
        public int pageIndex { get; set; }
        public int totalCount { get; set; }
        public int totalPages { get; set; }
    }
}
