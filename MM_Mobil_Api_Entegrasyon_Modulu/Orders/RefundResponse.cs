using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class RefundResponse
    {
        public RefundPage responsePage { get; set; }
        public RefundReport pageReport { get; set; }
        public List<RefundList> refundList { get; set; }
    }
}
