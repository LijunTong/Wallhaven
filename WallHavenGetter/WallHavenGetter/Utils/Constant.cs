using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallHavenGetter.Models;

namespace WallHavenGetter.Utils
{
    public static class Constant
    {
        /// <summary>
        /// 搜索类型latest、hot、toplist、random
        /// </summary>
        public static List<KeyVal> SerachType =>
            new List<KeyVal>()
            {
                new KeyVal
                {
                    Display = "最新",
                    Value = "latest",
                },
                new KeyVal
                {
                    Display = "当前最热",
                    Value = "hot",
                },
                new KeyVal
                {
                    Display = "近来最热",
                    Value = "toplist",
                },
                new KeyVal
                {
                    Display = "随机",
                    Value = "random",
                },
                new KeyVal
                {
                    Display = "自定义",
                    Value = "input",
                }

            };

        public static List<KeyVal> SortType =>
            new List<KeyVal>()
            {
                new KeyVal
                {
                    Display = "relevance",
                    Value = "relevance",
                },
                new KeyVal
                {
                    Display = "random",
                    Value = "random",
                },
                new KeyVal
                {
                    Display = "date_added",
                    Value = "date_added",
                },
                new KeyVal
                {
                    Display = "views",
                    Value = "views",
                },
                new KeyVal
                {
                    Display = "favorites",
                    Value = "favorites",
                },
                new KeyVal
                {
                    Display = "toplist",
                    Value = "toplist",
                },
                new KeyVal
                {
                    Display = "hot",
                    Value = "hot",
                }

            };
    }
}
