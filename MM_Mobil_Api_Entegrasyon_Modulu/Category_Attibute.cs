using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu
{
    public class Category_Attibute
    {
        private string url = "/category/getCategoryWithAttributes?Id=";
        public Category_Attibute(string Id)
        {
            if(Id.Length <= 0)
            {
                throw new ArgumentException("Id değeri zorunludur.");
                
            }

            this.url += Id;

        }

        public List<Category_Attibute> Category_Attibute_List()
        {

            var client = new Api.Client<Category_Attibute>();

            return client.GetMethodList(this.url);
        }

        /// <summary>
        /// Id değeri kategorinin bulunmuş olduğu değeri belirtmektedir.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// İlgili kategorinin adını belirtmektedir
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Kategorinin ön yüz tarafında görüneceği ismi belirtmektedir.
        /// </summary>
        public string displayName { get; set; }
        public List<Attribute> attributes { get; set; }

    }

    public class Attribute
    {
        /// <summary>
        /// Id değeri kategorinin bulunmuş olduğu değeri belirtmektedir.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// İlgili kategorinin adını belirtmektedir
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Kategorinin ön yüz tarafında görüneceği ismi belirtmektedir.
        /// </summary>
        public string displayName { get; set; }
        /// <summary>
        /// İlgili kategoriye aitözellikleri nvariant değeri true ise varyantlı olduğunu belirtmektedir.Bu değer false ise variant olmadığını belirtmektedir
        /// </summary>
        public bool isVariantable { get; set; }
        /// <summary>
        /// Bu değer true ise , ilgili kategoriyeözellik girişinin zorunlu olduğunu belirtmektedir.
        /// </summary>
        public bool isRequired { get; set; }
        public List<AttributeValues> attributeValues { get; set; }
    }

    public class AttributeValues
    {
        /// <summary>
        /// Kategoriye ait özellikleri içeren bölümünün id değerini belirtir.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Kategoriye ait özelliğin değerini ve bu özelliğin id değerini belirtir.
        /// </summary>
        public string value { get; set; }
    }
}
