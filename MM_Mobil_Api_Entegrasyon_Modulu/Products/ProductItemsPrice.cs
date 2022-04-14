using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Products
{
    public class ProductItemsPrice
    {
        private string _code;
        private decimal _listPrice;
        private decimal _salePrice;

        public ProductItemsPrice() { }

        public ProductItemsPrice(string code, decimal listPrice, decimal salePrice)
        {

            this._code = code;
            this._listPrice = listPrice;
            this._salePrice = salePrice;
        }

        public string code { get { return this._code; } set { this._code = value; } }
        public decimal listPrice { get { return this._listPrice; } set { this._listPrice = value; } }
        public decimal salePrice { get { return this._salePrice; } set { this._salePrice = value; } }
    }
}
