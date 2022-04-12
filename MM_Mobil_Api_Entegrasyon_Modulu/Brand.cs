using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu
{
    public class Brand
    {
        private int size;
        private int page;
        private string url = "/brand/getBrands?Page=";

        public Brand(int Size=1,int Page = 10)
        {

            this.size = Size;
            this.page = Page;
            this.url = this.page.ToString() + "&Size=" + this.size.ToString();
        }

        public List<Brand> BrandList()
        {

            var client = new Api.Client<Brand>();

            return client.GetMethodList(this.url);
        }

        public string id { get; set; }
        public string name { get; set; }
        public string logoUrl { get; set; }
        public string webSite { get; set; }
    }
}
