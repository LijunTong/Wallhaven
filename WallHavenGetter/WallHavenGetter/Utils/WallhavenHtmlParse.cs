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
        private static object _lockerSaveAs = new object();

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
                        DetialsUrl = detialsUrl,
                        JpgFullUrl = url + ".jpg",
                        PngFullUrl = url + ".png"
                    };
                    imgs.Add(imgInfo);
                }
            }
            return imgs;
        }

        public static string GetFullImgUrl(string detialUrl)
        {
            string dHtml = HttpHelper.HttpGet(detialUrl, 2);
            if (!string.IsNullOrEmpty(dHtml))
            {
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(dHtml);
                HtmlNode node = document.DocumentNode;
                var imgNode = node.SelectSingleNode(".//img[contains(@id,'wallpaper')]");
                if (imgNode != null)
                {
                    string fullurl = imgNode.GetAttributeValue("src", "");
                    return fullurl;
                }
            }
            return string.Empty;
        }

        public static string DownloadFullImage(WallhavenImgInfo imgInfo, string dir)
        {
            string path1 = Path.Combine(dir, imgInfo.ImageName + ".jpg");
            string path2 = Path.Combine(dir, imgInfo.ImageName + ".png");
            if (File.Exists(path1))
            {
                return path1;
            }
            if (File.Exists(path2))
            {
                return path2;
            }
            var stream = HttpHelper.HttpDownload(imgInfo.JpgFullUrl);
            if (stream != null)
            {
                lock (_lockerSaveAs)
                {
                    stream.SaveAs(path1);
                }
                return path1;
            }
            else
            {
                stream = HttpHelper.HttpDownload(imgInfo.PngFullUrl);
                if (stream != null)
                {
                    lock (_lockerSaveAs)
                    {
                        stream.SaveAs(path2);
                    }
                    return path2;
                }
                return "";
            }
        }
    }
}
