using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Models
{
    public class SerachParam
    {
        public string BaseUrl { get; set; }
        public string Type { get; set; }
        public int Page { get; set; }
        public string Url
        {
            get
            {
                return $"{BaseUrl}{Type}";
            }
        }
        public List<string> PageUrls()
        {
            List<string> urls = new List<string>(); 
            for (int i = 1; i <= Page; i++)
            {
                urls.Add($"{BaseUrl}{Type}?page={i}");
            }
            return urls;
        }
            
    }
}
