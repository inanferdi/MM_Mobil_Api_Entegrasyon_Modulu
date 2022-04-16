using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class RefundUpdateResponse
    {
        public int orderNumber { get; set; }
        public int requestNo { get; set; }
        public string refundId { get; set; }
        public string orderItemId { get; set; }
        public string refundType { get; set; }
        public string refundStatus { get; set; }
    }
}
