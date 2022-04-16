using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class RefundUpdate
    {
        private string RefundId;
        private int Status;

        public RefundUpdate(string RefundId,int Status)
        {
            this.RefundId = RefundId;
            this.Status = Status;
        }

        public RefundUpdateResponse UpdateRefund()
        {

            string url = "/order/updateRefund";

            var client = new Api.Client<RefundUpdateResponse>();

            var result = client.PostMethod(this, url);

            return result;
        }

        public string refundId { get { return this.RefundId; } set { this.RefundId = value; } }
        public int status { get { return this.Status; } set { this.Status = value; } }
    }
}
