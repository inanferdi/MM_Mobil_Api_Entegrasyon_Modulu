using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class OrderRefund
    {
        private int PageSize;
        private int PageNumber;
        private int OrderNumber;
        private int RefundStatus;
        private int RefundNumber;
        private int ShipmentCode;
        private string RequestStartDate;
        private string RequestEndDate;

        public OrderRefund(int PageSize,int PageNumber,int OrderNumber,int RefundStatus,int RefundNumber,
            int ShipmentCode,DateTime RequestStartDate,DateTime RequestEndDate)
        {
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.OrderNumber = OrderNumber;
            this.RefundStatus = RefundStatus;
            this.RefundNumber = RefundNumber;
            this.RequestStartDate = RequestStartDate.ToString("yyyy-MM-dd");
            this.RequestEndDate = RequestEndDate.ToString("yyyy-MM-dd");
        }

        public RefundResponse GetRefund()
        {

            string url = "/order/getRefund";

            var client = new Api.Client<RefundResponse>();

            var result = client.PostMethod(this, url);

            return result;
        }


        public int pageSize { get { return this.pageSize; } set { this.pageSize = value; } }
        public int pageNumber { get { return this.PageNumber; } set { this.PageNumber = value; } }
        public int orderNumber { get { return this.OrderNumber; } set { this.OrderNumber = value; } }
        public int refundStatus { get { return this.RefundStatus; } set { this.RefundStatus = value; } }
        public int refundNumber { get { return this.RefundNumber; } set { this.RefundNumber = value; } }
        public int shipmentCode { get { return this.ShipmentCode; } set { this.ShipmentCode = value; } }
        public string requestStartDate { get { return this.RequestStartDate; } set { this.RequestStartDate = value; } }
        public string requestEndDate { get { return this.RequestEndDate; } set { this.RequestEndDate = value; } }
    }
}
