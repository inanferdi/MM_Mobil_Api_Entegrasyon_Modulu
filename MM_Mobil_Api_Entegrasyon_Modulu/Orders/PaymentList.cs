using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class PaymentList
    {
        public string transactionId { get; set; }
        public int orderNumber { get; set; }
        public decimal price { get; set; }
        public string currencyCode { get; set; }
        public string status { get; set; }
        public DateTime paymentperioddate { get; set; }
        public decimal commission { get; set; }
        public decimal commissionRate { get; set; }
        public int paymentPeriod { get; set; }
        public DateTime orderDate { get; set; }

        public List<PaymentList> GetPaymentList(long startDate,long endDate)
        {

            string url = $"/getPaymentList?startDate={startDate}&endDate={endDate}";

            var client = new Api.Client<PaymentList>();

            var result = client.GetMethodList(url);

            return result;
        }
    }
}
