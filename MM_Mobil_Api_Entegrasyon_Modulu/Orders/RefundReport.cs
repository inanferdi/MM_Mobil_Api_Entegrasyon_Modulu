using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class RefundReport
    {
        public int totalRefundCount { get; set; }
        public int totalWaitingRefundCount { get; set; }
        public int totalApprovedRefundCount { get; set; }
        public int totalRejectedRefundCount { get; set; }
    }
}
