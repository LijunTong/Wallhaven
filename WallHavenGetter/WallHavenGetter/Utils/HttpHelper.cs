using Microsoft.Extensions.Logging;
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
        private ILogger<HttpHelper> _logger;

        public HttpHelper(ILogger<HttpHelper> logger)
        {
            _logger = logger;
        }

        public string HttpGet(string url,int cnt = 1)
        {
            if (cnt == 0)
            {
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
                        _logger.LogError(url + ":" + reaponse.StatusCode);
                        return HttpGet(url, --cnt);
                    }
                }
                else
                {
                    _logger.LogError(url + ":reaponse is null");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(url + ":" + ex.Message);
            }
            return String.Empty;
        }

        public Stream HttpDownload(string url)
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
                        _logger.LogError(url + ":" + reaponse.StatusCode);
                    }
                }
                else
                {
                    _logger.LogError(url + ":reaponse is null");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(url + ":" + ex.Message);
            }
            return null;
        }
    }
}
