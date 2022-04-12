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
    public class Token
    {
        private string _token = null;

        public string token { get { return this._token; } }

        public Token()
        {

            this.TokenOlustur();
        }

        private void TokenOlustur()
        {

            string clientId = "4b618ce6cbe642d8bfa1d64907631277";
            string clientSecret = "9e7e5b85bd6548ad8bf9b54e0c7d1144";
            HttpClient client = new HttpClient();
            Uri baseUri = new Uri("https://isortagimgiristest.pazarama.com");
            client.BaseAddress = baseUri;
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.ConnectionClose = true;

            
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            values.Add(new KeyValuePair<string, string>("scope", "merchantgatewayapi.fullaccess"));
            var content = new FormUrlEncodedContent(values);

            var authenticationString = $"{clientId}:{clientSecret}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/connect/token");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
            requestMessage.Content = content;

            
            var task = client.SendAsync(requestMessage);
            var response = task.Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result.Split(':')[6].ToString().Split(',')[0];
            
            this._token = responseBody;
        }




    }
}
