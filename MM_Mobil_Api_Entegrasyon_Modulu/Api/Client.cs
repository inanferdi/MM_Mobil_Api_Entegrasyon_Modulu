using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MM_Mobil_Api_Entegrasyon_Modulu.Api
{
    public class Client<T>
    {
        private HttpClient _client;
        private string baseUrl = "https://isortagimgiristest.pazarama.com";
        private string token;

        public Client()
        {

            this._client = new HttpClient();
            Uri baseUri = new Uri(this.baseUrl);
            this._client.BaseAddress = baseUri;
            this._client.DefaultRequestHeaders.Clear();
            this._client.DefaultRequestHeaders.ConnectionClose = true;
            this.token = new Token().token;
            this._client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.token);
        }

        public T PostMethod (object data,string url)
        {
            var jsData = JsonConvert.SerializeObject(data, Formatting.Indented);
            var contentData = new StringContent(jsData, Encoding.UTF8, "application/json");
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
            requestMessage.Content = contentData;
            var task = this._client.SendAsync(requestMessage);
            var response = task.Result;
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(responseBody);

        }

        public T PutMethod(object data, string url)
        {
            var jsData = JsonConvert.SerializeObject(data, Formatting.Indented);
            var contentData = new StringContent(jsData, Encoding.UTF8, "application/json");
            var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
            requestMessage.Content = contentData;
            var task = this._client.SendAsync(requestMessage);
            var response = task.Result;
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(responseBody);

        }

        public List<T> PostMethodList(object data, string url)
        {
            var jsData = JsonConvert.SerializeObject(data, Formatting.Indented);
            var contentData = new StringContent(jsData, Encoding.UTF8, "application/json");
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
            requestMessage.Content = contentData;
            var task = this._client.SendAsync(requestMessage);
            var response = task.Result;
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<T>>(responseBody);

        }



        public T GetMethod(string url)
        {

            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            var task = this._client.SendAsync(requestMessage);
            var response = task.Result;
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public List<T> GetMethodList(string url)
        {
            try
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
                var task = this._client.SendAsync(requestMessage);
                var response = task.Result;
                response.EnsureSuccessStatusCode();

                string responseBody = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<List<T>>(responseBody.ToString().Replace("data:", "")); 
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString()) ;
            }
            
        }

    }
}
