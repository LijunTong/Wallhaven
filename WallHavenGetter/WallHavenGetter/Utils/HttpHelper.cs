using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Utils
{
    public class HttpHelper
    {
        private const string EdgeUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.54 Safari/537.36 Edg/101.0.1210.39";
       
        public static string HttpGet(string url,int cnt)
        {
            if (cnt == 0)
            {
                //Console.WriteLine(url + ":" + "reaponse is fail");
                return "";
            }
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
                    else
                    {
                        return HttpGet(url, --cnt);
                    }
                }
                else
                {
                    //Console.WriteLine(url + ":" + "reaponse is null");
                }
            }
            catch (Exception)
            {
                //Console.WriteLine(url + ":" + ex.ToString());
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
                    else
                    {
                        //Console.WriteLine(url + ":" + "reaponse is fail");
                    }
                }
                else
                {
                    //Console.WriteLine(url + ":" + "reaponse is null");
                }
            }
            catch (Exception )
            {
                //Console.WriteLine(url + ":" + ex.ToString());
            }
            return null;
        }
    }
}
