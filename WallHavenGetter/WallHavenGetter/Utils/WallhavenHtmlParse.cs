using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WallHavenGetter.Models;

namespace WallHavenGetter.Utils
{
    public class WallhavenHtmlParse
    {
        public static List<string> GetSmallImgUrl(Uri uri)
        {
            string html = HttpHelper.HttpGet(uri.ToString(), 2);
            return GetSmallImgUrl(html);
        }

        /// <summary>
        /// 获取缩略图地址
        /// </summary>
        /// <returns></returns>
        public static List<string> GetSmallImgUrl(string html)
        {
            List<string> smallImgUrls = new List<string>();
            if (string.IsNullOrEmpty(html))
            {
                return smallImgUrls;
            }
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);
            HtmlNode node = document.DocumentNode;
            var lazyloadImgNodes = node.SelectNodes(".//img[contains(@class,'lazyload')]");
            if (lazyloadImgNodes != null && lazyloadImgNodes.Count > 0)
            {
                foreach (var item in lazyloadImgNodes)
                {
                    string smallUrl = item.GetAttributeValue("data-src", "");
                    if (smallUrl != null)
                    {
                        smallImgUrls.Add(smallUrl);
                    }
                }
            }
            return smallImgUrls;
        }

        /// <summary>
        /// 获取图地址
        /// </summary>
        /// <returns></returns>
        public static List<WallhavenImgInfo> ParseImgUrl(List<string> smallUrls)
        {
            List<WallhavenImgInfo> imgs = new List<WallhavenImgInfo>();
            Regex regexSmallImg = new Regex(Constant.WallhavenSmallImgUrlRegex);
            foreach (var item in smallUrls)
            {
                if (regexSmallImg.IsMatch(item))
                {
                    var grroups = regexSmallImg.Match(item).Groups;
                    string url = regexSmallImg.Replace(item, Constant.WallhavenImgBaseUrlFormat);
                    string detialsUrl = regexSmallImg.Replace(item, Constant.WallhavenImgDetialsUrlFormat);
                    WallhavenImgInfo imgInfo = new WallhavenImgInfo()
                    {
                        ImageName = grroups[2].Value,
                        Extension = grroups[3].Value,
                        SmallUrl = item,
                        DetialsUrl = detialsUrl
                    };
                    imgs.Add(imgInfo);
                }
            }
            return imgs;
        }

        public static string GetFullImgUrl(string detialUrl)
        {
            string dHtml = HttpHelper.HttpGet(detialUrl, 2);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(dHtml);
            HtmlNode node = document.DocumentNode;
            var imgNode = node.SelectSingleNode(".//img[contains(@id,'wallpaper')]");
            if (imgNode != null)
            {
                return imgNode.GetAttributeValue("src", "");
            }
            return string.Empty;
        }


    }
}
