using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu
{
    public class Category
    {
        /// <summary>
        /// Id değeri kategorinin bulunmuş olduğu değeri belirtmektedir.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// İlgili kategorinin ana kategorisini belirtmektedir.
        /// </summary>
        public string parentId { get; set; }
        /// <summary>
        /// Alt kırılımlarıyla birlikte kategoriye aitbilgileri listelemeyisağlamaktadır.
        /// </summary>
        public List<string> parentCategories { get; set; }
        /// <summary>
        /// İlgili kategorinin adını belirtmektedir.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Kategorinin ön yüztarafında görüneceği ismi belirtmektedir
        /// </summary>
        public string displayName { get; set; }
        /// <summary>
        /// Kategori sırasının default değerini belirtmektedir.
        /// </summary>
        public int displayOrder { get; set; }
        /// <summary>
        /// İlgili kategorinin açıklamasını belirtmektedir.
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Bu değer true olduğunda en alt kategori olduğunu belirtmektedir.
        /// </summary>
        public bool leaf { get; set; }

        public List<Category> CategoryList()
        {

            var client = new Api.Client<Category>();

            return client.GetMethodList("/category/getCategoryTree");
        }
    }
}
