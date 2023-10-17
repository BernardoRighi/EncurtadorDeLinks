using Newtonsoft.Json;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BitLyAPI
{
    public class BitLyAPI
    {
        private string _bitLyApiURL;
        private string _bitLyApiToken;

        public BitLyAPI()
        {
            _bitLyApiURL = ConfigurationManager.AppSettings["BitLyAPIUrl"];
            _bitLyApiToken = ConfigurationManager.AppSettings["BitLyAPIToken"];
        }

        public async Task<string> ShortenAsync(string long_url)
        {
            return await Task.Run(() => Shorten(long_url));
        }

        private string Shorten(string long_url)
        {
            if (CheckAccessToken())
            {
                using (HttpClient client = new HttpClient())
                {
                    string temp = string.Format(_bitLyApiURL, _bitLyApiToken, WebUtility.UrlEncode(long_url));
                    var response = client.GetAsync(temp).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var message = response.Content.ReadAsStringAsync().Result;
                        dynamic obj = JsonConvert.DeserializeObject(message);
                        return obj.results[long_url].shortUrl;
                    }
                    else
                    {
                        return "Não foi possível encurtar a URL";
                    }
                }
            }
            else
            {
                return "Não foi possível validar o token de acesso e encurtar a URL";
            }
        }

        private bool CheckAccessToken()
        {
            if (string.IsNullOrEmpty(_bitLyApiToken))
                return false;

            string temp = string.Format(_bitLyApiURL, _bitLyApiToken, "google.com");
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(temp).Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}
