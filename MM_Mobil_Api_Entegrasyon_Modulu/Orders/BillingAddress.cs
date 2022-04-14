using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Orders
{
    public class BillingAddress : ShipmentAddress
    {
        public string identityNumber { get; set; }
        public int invoiceType { get; set; }
        public string companyName { get; set; }
        public int taxNumber { get; set; }
        public string taxOffice { get; set; }
        public bool isEInvoiceObliged { get; set; }
    }
}
