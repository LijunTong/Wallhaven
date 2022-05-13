using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallHavenGetter.Models;
using WallHavenGetter.Utils;

namespace WallHavenGetter.Services
{
    public class ApiWallhavenService : IWallhavenService
    {
        private object _lockerSaveAs = new object();
        private AppOptions _appOptions;
        private OptionsService _optionsService;
        private HttpHelper _httpHelper;
        private JsonHelper _jsonHelper;

        public ApiWallhavenService(HttpHelper httpHelper,
                                   OptionsService optionsService,
                                   JsonHelper jsonHelper)
        {
            _optionsService = optionsService;
            _appOptions = _optionsService.GetAppOptions();
            _httpHelper = httpHelper;
            _jsonHelper = jsonHelper;
        }

        public string DownloadFullImage(WallhavenImgInfo imgInfo, string dir)
        {
            string path = Path.Combine(dir, imgInfo.ImageName + "." + imgInfo.Extension);
            if (File.Exists(path))
            {
                return path;
            }
            Stream stream = _httpHelper.HttpDownload(imgInfo.JpgFullUrl);
            if (stream != null)
            {
                lock (_lockerSaveAs)
                {
                    stream.SaveAs(path);
                }
                return path;
            }
            return "";
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
                }
                return path;
            }
            return "";
        }

        public List<WallhavenImgInfo> GetSmallImgUrl(Uri uri)
        {
            return GetSmallImgUrl(uri.ToString());
        }

        public List<WallhavenImgInfo> GetSmallImgUrl(string html)
        {
            List<WallhavenImgInfo> wallhavenImgs = new List<WallhavenImgInfo>();
            string json = _httpHelper.HttpGet(html);
            if (_jsonHelper.TryToObj(json, out SearchResult result))
            {
                if (result.Data != null)
                {
                    for (int i = 0; i < result.Data.Length; i++)
                    {
                        var img = result.Data[i];
                        if (!string.IsNullOrEmpty(img.Path))
                        {
                            wallhavenImgs.Add(new WallhavenImgInfo
                            {
                                ImageName = img.Id,
                                SmallUrl = img.Thumbs.Original,
                                DetialsUrl = img.Url,
                                JpgFullUrl = img.Path,
                                Extension = img.Path.Split('.')[1],
                            });
                        }
                    }
                }
            }
            return wallhavenImgs;
        }

        public List<WallhavenImgInfo> ParseImgUrl(List<WallhavenImgInfo> smallUrls)
        {
            return smallUrls;
        }
    }
}
