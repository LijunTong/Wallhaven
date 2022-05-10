using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Models
{
    /// <summary>
    /// https://wallhaven.cc/search?q=cat&categories=111&purity=110&sorting=relevance&order=desc
    /// </summary>
    public class SerachParam
    {
        public string BaseUrl { get; set; }
        public string Type { get; set; }
        public string Q { get; set; }
        public string Categories { get; set; }
        public string Purity { get; set; } = "110";
        public string Sorting { get; set; }
        public string Order { get; set; } = "desc";
        public int Page { get; set; }
        public string Url
        {
            get
            {
                if (Type != "input")
                {
                    return $"{BaseUrl}{Type}";
                }
                string q = string.IsNullOrEmpty(Q) ? "" : $"q={Q}&";
                string categories = string.IsNullOrEmpty(Categories) ? "" : $"categories={Categories}&";
                string purity = string.IsNullOrEmpty(Purity) ? "" : $"purity={Purity}&";
                string sorting = string.IsNullOrEmpty(Sorting) ? "" : $"sorting={Sorting}&";
                string order = string.IsNullOrEmpty(Order) ? "" : $"order={Order}";
                return $"{BaseUrl}search?{q}{categories}{purity}{sorting}{order}";
            }
        }
        public List<string> PageUrls()
        {
            List<string> urls = new List<string>(); 
            for (int i = 1; i <= Page; i++)
            {
                if (Type == "input")
                {
                    urls.Add($"{Url}&page={i}");
                }
                else
                {
                    urls.Add($"{Url}?page={i}");
                }
            }
            return urls;
        }
            
    }
}
