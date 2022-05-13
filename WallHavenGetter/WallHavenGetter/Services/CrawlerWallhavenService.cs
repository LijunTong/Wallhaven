using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WallHavenGetter.Models;
using WallHavenGetter.Services;
using WallHavenGetter.Utils;

namespace WallHavenGetter.Services
{
    public class CrawlerWallhavenService: IWallhavenService
    {
        private object _lockerSaveAs = new object();
        private AppOptions _appOptions;
        private OptionsService _optionsService;
        private HttpHelper _httpHelper;

        public CrawlerWallhavenService(OptionsService optionsService, HttpHelper httpHelper)
        {
            _optionsService = optionsService;
            _appOptions = _optionsService.GetAppOptions();
            _httpHelper = httpHelper;
        }

        public List<WallhavenImgInfo> GetSmallImgUrl(Uri uri)
        {
            string html = _httpHelper.HttpGet(uri.ToString(), 2);
            return GetSmallImgUrl(html);
        }

        /// <summary>
        /// 获取缩略图地址
        /// </summary>
        /// <returns></returns>
        public List<WallhavenImgInfo> GetSmallImgUrl(string html)
        {
            List<WallhavenImgInfo> smallImgUrls = new List<WallhavenImgInfo>();
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
                        smallImgUrls.Add(new WallhavenImgInfo
                        {
                            SmallUrl = smallUrl,
                        });
                    }
                }
            }
            return smallImgUrls;
        }

        /// <summary>
        /// 获取图地址
        /// </summary>
        /// <returns></returns>
        public List<WallhavenImgInfo> ParseImgUrl(List<WallhavenImgInfo> smallUrls)
        {
            List<WallhavenImgInfo> imgs = new List<WallhavenImgInfo>();
            Regex regexSmallImg = new Regex(_appOptions.WallhavenSmallImgUrlRegex);
            foreach (var item in smallUrls)
            {
                if (regexSmallImg.IsMatch(item.SmallUrl))
                {
                    var grroups = regexSmallImg.Match(item.SmallUrl).Groups;
                    string url = regexSmallImg.Replace(item.SmallUrl, _appOptions.WallhavenImgBaseUrlFormat);
                    string detialsUrl = regexSmallImg.Replace(item.SmallUrl, _appOptions.WallhavenImgDetialsUrlFormat);
                    WallhavenImgInfo imgInfo = new WallhavenImgInfo()
                    {
                        ImageName = grroups[2].Value,
                        Extension = grroups[3].Value,
                        SmallUrl = item.SmallUrl,
                        DetialsUrl = detialsUrl,
                        JpgFullUrl = url + ".jpg",
                        PngFullUrl = url + ".png"
                    };
                    imgs.Add(imgInfo);
                }
            }
            return imgs;
        }

        public string GetFullImgUrl(string detialUrl)
        {
            string dHtml = _httpHelper.HttpGet(detialUrl, 2);
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

        public string DownloadFullImage(WallhavenImgInfo imgInfo, string dir)
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
            var stream = _httpHelper.HttpDownload(imgInfo.JpgFullUrl);
            if (stream != null)
            {
                lock (_lockerSaveAs)
                {
                    stream.SaveAs(path1);
                    stream.Close();
                    stream.Dispose();
                }
                return path1;
            }
            else
            {
                stream = _httpHelper.HttpDownload(imgInfo.PngFullUrl);
                if (stream != null)
                {
                    lock (_lockerSaveAs)
                    {
                        stream.SaveAs(path2);
                        stream.Close();
                        stream.Dispose();
                    }
                    return path2;
                }
                return "";
            }
        }

        public string DownloadSmallImg(WallhavenImgInfo imgInfo, string dir)
        {
            string path = Path.Combine(dir, imgInfo.ImageName + "." + imgInfo.Extension);
            if (File.Exists(path))
            {
                return path;
            }
            Stream stream = _httpHelper.HttpDownload(imgInfo.SmallUrl);
            if (stream != null)
            {
                lock (_lockerSaveAs)
                {
                    stream.SaveAs(path);
                    stream.Close();
                    stream.Dispose();
                }
                return path;
            }
            return "";
        }
    }
}
