using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu
{
    public class Cities
    {
        public string id { get; set; }
        public int code { get; set; }
        public string name { get; set; }

        public List<Cities> CitiesList()
        {

            string url = "/parameter/cities";

            var client = new Api.Client<Cities>();

            return client.GetMethodList(url);
        }
    }
}
