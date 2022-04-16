using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class InvoiceLink
    {
        private string _invoiceLink;
        private string _orderid;

        public InvoiceLink(string _invoiceLink,string _orderid)
        {

            this._invoiceLink = _invoiceLink;
            this._orderid = _orderid;
        }

        public void UpdateInvoiceLink()
        {

            string url = "/sendInvoiceLink";

            var client = new Api.Client<HelperResponse>();

            var result = client.PostMethod(this, url);

            if (!result.success) throw new ArgumentException("Fatura linki güncelleme yapılamadı. " + result.message);
        }

        public string invoiceLink { get { return this._invoiceLink; } set { this._invoiceLink = value; } }
        public string orderid { get { return this._orderid; }  set { this._orderid = value; } }
    }
}
