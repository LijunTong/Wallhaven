using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallHavenGetter.Models;

namespace WallHavenGetter.Services
{
    public interface IWallhavenService
    {
        List<WallhavenImgInfo> GetSmallImgUrl(Uri uri);
        List<WallhavenImgInfo> GetSmallImgUrl(string html);
        List<WallhavenImgInfo> ParseImgUrl(List<WallhavenImgInfo> smallUrls);
        string DownloadFullImage(WallhavenImgInfo imgInfo, string dir);
        string DownloadSmallImg(WallhavenImgInfo imgInfo, string dir);
    }
}
