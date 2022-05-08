using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Utils
{
    public class HttpHelper
    {
        private const string EdgeUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.54 Safari/537.36 Edg/101.0.1210.39";
       
        public static string HttpGet(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("user-agent", EdgeUserAgent);
                client.DefaultRequestHeaders.Referrer = new Uri(url);
                var reaponse = client.GetAsync(url).Result;
                if (reaponse != null)
                {
                    if (reaponse.IsSuccessStatusCode)
                    {
                        return reaponse.Content.ReadAsStringAsync().Result;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return String.Empty;
        }

        public static Stream HttpDownload(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("user-agent", EdgeUserAgent);
                client.DefaultRequestHeaders.Referrer = new Uri(url);
                var reaponse = client.GetAsync(url).Result;
                if (reaponse != null)
                {
                    if (reaponse.IsSuccessStatusCode)
                    {
                        return reaponse.Content.ReadAsStream();
                    }
                }
            }
            catch (Exception)
            {

            }
            return null;
        }

        private static List<ProductInfoHeaderValue> GetProductInfoHeaderValues()
        {
            return new List<ProductInfoHeaderValue>()
            {
                new ProductInfoHeaderValue("Mozilla/5.0"),
                new ProductInfoHeaderValue("(Windows NT 10.0; Win64; x64)"),
                new ProductInfoHeaderValue("AppleWebKit","537.36"),
                new ProductInfoHeaderValue("Chrome","101.0.4951.54"),
                new ProductInfoHeaderValue("Safari","537.36"),
                new ProductInfoHeaderValue("Edg","101.0.1210.39")
            };
        }
    }
}
