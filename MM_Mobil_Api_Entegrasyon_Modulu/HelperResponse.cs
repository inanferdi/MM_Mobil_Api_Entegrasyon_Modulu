using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu
{
    public class HelperResponse
    {
        public object data { get; set; }
        public bool success { get; set; }
        public int messageCode { get; set; }
        public string message { get; set; }
        public string userMessage { get; set; }
    }
}
