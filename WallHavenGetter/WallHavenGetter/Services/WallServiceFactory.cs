using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallHavenGetter.Models;

namespace WallHavenGetter.Services
{
    public class WallServiceFactory
    {
        private OptionsService _optionsService;
        private AppOptions _appOptions;

        public WallServiceFactory(OptionsService optionsService)
        {
            _optionsService = optionsService;
            _appOptions = optionsService.GetAppOptions();
        }


        public IWallhavenService Get()
        {
            if(_appOptions.Mode == "爬虫")
            {
                return AppContext.GetService<CrawlerWallhavenService>();
            }
            else
            {
                return AppContext.GetService<ApiWallhavenService>();
            }
        }
    }
}
