using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallHavenGetter.Enums;

namespace WallHavenGetter.Models
{
    public class AppOptions
    {
        public int ThreadCount { get; set; }
        public string Mode { get; set; }
        public string Url
        {
            get
            {
                if (Mode == "爬虫")
                {
                    return WallhavenBaseUrl;
                }
                else
                {
                    return ApiUrl;
                }
            }
        }
        public string ApiUrl { get; set; }
        public string WallhavenBaseUrl { get; set; }
        public string WallhavenImgBaseUrlFormat { get; set; }
        public string WallhavenImgDetialsUrlFormat { get; set; }
        public string WallhavenSmallImgUrlRegex { get; set; }
        public string FullImageDir { get; set; }
        public string SmallImageDir { get; set; }
    }
}
