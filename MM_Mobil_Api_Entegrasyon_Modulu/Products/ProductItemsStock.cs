using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Products
{
    public class ProductItemsStock
    {
        private string _code;
        private int _stockCount;

        public ProductItemsStock()
        {


        }

        public ProductItemsStock(string code,int stockCount)
        {

            this._code = code;
            this._stockCount = stockCount;
        }

        public string code { get { return this._code; } set { this._code = value; } }
        public int stockCount { get { return this._stockCount; } set { this._stockCount = value; } }
    }
}
