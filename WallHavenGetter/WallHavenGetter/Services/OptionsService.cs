using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallHavenGetter.Models;
using WallHavenGetter.Utils;

namespace WallHavenGetter.Services
{
    public class OptionsService
    {
        private IniFileHelper _iniFileHelper;

        public OptionsService(IniFileHelper fileHelper)
        {
            _iniFileHelper = fileHelper;
        }

        public AppOptions GetAppOptions()
        {
            AppOptions appOptions = new AppOptions();
            appOptions.ThreadCount = _iniFileHelper.GetIniInt("AppOptions", "ThreadCount", 4);
            appOptions.WallhavenBaseUrl = _iniFileHelper.GetIniString("AppOptions", "WallhavenBaseUrl", "https://wallhaven.cc/");
            appOptions.WallhavenImgBaseUrlFormat = _iniFileHelper.GetIniString("AppOptions", "WallhavenImgBaseUrlFormat", "https://w.wallhaven.cc/full/$1/wallhaven-$2");
            appOptions.WallhavenImgDetialsUrlFormat = _iniFileHelper.GetIniString("AppOptions", "WallhavenImgDetialsUrlFormat", "https://wallhaven.cc/w/$2");
            appOptions.WallhavenSmallImgUrlRegex = _iniFileHelper.GetIniString("AppOptions", "WallhavenSmallImgUrlRegex", "^https://th.wallhaven.cc/small/([0-9a-z]*)/([0-9a-z]{6}).([a-z]{3,4})$");
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "full");
            appOptions.FullImageDir = _iniFileHelper.GetIniString("AppOptions", "FullImageDir", dir);
            appOptions.SmallImageDir = _iniFileHelper.GetIniString("AppOptions", "SmallImageDir", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "small"));
            appOptions.Mode = _iniFileHelper.GetIniString("AppOptions", "Mode", "爬虫");
            appOptions.ApiUrl = _iniFileHelper.GetIniString("AppOptions", "ApiUrl", "https://wallhaven.cc/api/v1/");
            return appOptions;
        }

        public void SetAppOptions(AppOptions appOptions)
        {
            _iniFileHelper.WriteIniInt("AppOptions", "ThreadCount", appOptions.ThreadCount);
            _iniFileHelper.WriteIniString("AppOptions", "WallhavenBaseUrl", appOptions.WallhavenBaseUrl);
            _iniFileHelper.WriteIniString("AppOptions", "WallhavenImgBaseUrlFormat", appOptions.WallhavenImgBaseUrlFormat);
            _iniFileHelper.WriteIniString("AppOptions", "WallhavenImgDetialsUrlFormat", appOptions.WallhavenImgDetialsUrlFormat);
            _iniFileHelper.WriteIniString("AppOptions", "WallhavenSmallImgUrlRegex", appOptions.WallhavenSmallImgUrlRegex);
            _iniFileHelper.WriteIniString("AppOptions", "FullImageDir", appOptions.FullImageDir);
            _iniFileHelper.WriteIniString("AppOptions", "SmallImageDir", appOptions.SmallImageDir);
            _iniFileHelper.WriteIniString("AppOptions", "Mode", appOptions.Mode);
            _iniFileHelper.WriteIniString("AppOptions", "ApiUrl", appOptions.ApiUrl);
        }
    }
}
