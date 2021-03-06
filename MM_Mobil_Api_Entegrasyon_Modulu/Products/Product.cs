using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Products
{
    public class Product
    {
        private string Name;
        private string DisplayName;
        private string Description;
        private string BrandId;
        private int Desi;
        private int Code;
        private string GroupCode;
        private int StockCount;
        private string StockCode;
        private int VatRate;
        private decimal ListPrice;
        private decimal SalePrice;
        private string CategoryId;
        private List<AttributeValues> Attributes;
        private Deliveries Deliveries;
        private List<Images> Images;


        /// <summary>
        ///  Product Create
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="DisplayName"></param>
        /// <param name="Description"></param>
        /// <param name="BrandId"></param>
        /// <param name="Desi"></param>
        /// <param name="Code"></param>
        /// <param name="GroupCode"></param>
        /// <param name="StockCount"></param>
        /// <param name="StockCode"></param>
        /// <param name="VatRate"></param>
        /// <param name="ListPrice"></param>
        /// <param name="SalePrice"></param>
        /// <param name="CategoryId"></param>
        /// <param name="Attributes"></param>
        /// <param name="Deliveries"></param>
        /// <param name="Images"></param>
        public Product
            (
                string Name,string DisplayName,string Description,string BrandId,
                int Desi,int Code,string GroupCode,int StockCount,string StockCode,
                int VatRate,decimal ListPrice,decimal SalePrice,string CategoryId,
                List<AttributeValues> Attributes, Deliveries Deliveries,List<Images> Images
            )
        {
            #region alan kontrolleri 

            Karekter_Kontrol(100, Name);
            Karekter_Kontrol(250, DisplayName);
            Karekter_Kontrol(500, Description);
            Karekter_Kontrol(10, GroupCode);
            Karekter_Kontrol(100, StockCode);
           

            #endregion
            this.Name = Name;
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.BrandId = BrandId;
            this.Desi = Desi;
            this.Code = Code;
            this.GroupCode = GroupCode;
            this.StockCount = StockCount;
            this.StockCode = StockCode;
            this.VatRate = VatRate;
            this.ListPrice = ListPrice;
            this.SalePrice = SalePrice;
            this.CategoryId = CategoryId;
            this.Attributes = Attributes;
            this.Deliveries = Deliveries;
            this.Images = Images;

        }


        

        public void Karekter_Kontrol(int uzunluk,string alan_adi)
        {
            if (alan_adi.Length > uzunluk) throw new ArgumentException("' " + alan_adi + " '" + " en fazla 100 karekter olabilir.");
        }

        public void ProductCreate()
        {

            string url = "/product/create";

            var client = new Api.Client<ProductResponse>();

            var result = client.PostMethod(this, url);

            UrunKayitKontrol(result.batchRequestId);
        }

        private void UrunKayitKontrol(string BatchRequestId)
        {

            var client = new Api.Client<ProductResponse>();

            string url = "/product/getProductBatchResult?BatchRequestId=" + BatchRequestId;

            var result = client.GetMethod(url);

            if (result.failedCount > 0) throw new ArgumentException("Ürün Kaydı Yapılamadı.");
        }

        public void ProductUpdatePrice(List<ProductItemsPrice> items)
        {

            var client = new Api.Client<HelperResponse>();

            string url = "/product/updatePrice";

            var result = client.PostMethod(items, url);

            if (!result.success) throw new ArgumentException("Fiyat Güncelleme Yapılamadı.");
        }

        public void ProductUpdateStock(List<ProductItemsStock> items)
        {

            var client = new Api.Client<HelperResponse>();

            string url = "/product/updateStock";

            var result = client.PostMethod(items, url);

            if (!result.success) throw new ArgumentException("Stok Güncelleme Yapılamadı.");
        }

        /// <summary>
        /// Code parametresi hiç gönderilmez ise, tüm onaylanmış ve onaylanmamış ürünler listelenir.
        /// 
        /// </summary>
        /// <param name="Approved"></param>
        /// <param name="Code"></param>
        /// <param name="Page"></param>
        /// <param name="Size"></param>
        /// <returns></returns>
        public List<Product> ProductFilterList(bool Approved,int Code=0, int Page=1,int Size = 100)
        {
            string url = $"http://%7Bbaseurl%7D/product/products?Approved={Approved}&Code={Code}&Size={Size}&Page={Page}";

            if (Code == 0) url = $"http://%7Bbaseurl%7D/product/products?Approved={Approved}&Size={Size}&Page={Page}";

            var client = new Api.Client<Product>();

            var result = client.GetMethodList(url);

            return result;

        }

        public string name { get { return this.Name; } set { this.Name = value; } }
        public string displayName { get { return this.DisplayName; } set { this.DisplayName = value; } }
        public string description { get { return this.Description; } set { this.Description = value; } }
        public string brandId { get { return this.BrandId; } set { this.BrandId = value; } }
        public int desi { get { return this.Desi; } set { this.Desi = value; } }
        public int code { get { return this.Code; } set { this.Code = value; } }
        public string groupCode { get { return this.GroupCode; } set { this.GroupCode = value; } }
        public int stockCount { get { return this.StockCount; } set { this.StockCount = value; } }
        public string stockCode { get { return this.StockCode; } set { this.StockCode = value; } }
        public int vatRate { get { return this.VatRate; } set { this.VatRate = value; } }
        public decimal listPrice { get { return this.ListPrice; } set { this.ListPrice = value; } }
        public decimal salePrice { get { return this.SalePrice; } set { this.SalePrice = value; } }
        public string categoryId { get { return this.CategoryId; } set { this.CategoryId = value; } }
        public List<AttributeValues> attributes { get { return this.Attributes; } set { this.Attributes = value; } }
        public Deliveries deliveries { get { return this.Deliveries; } set { this.Deliveries = value; } }
        public List<Images> images { get { return this.Images; } set { this.Images = value; } }

    }
}
