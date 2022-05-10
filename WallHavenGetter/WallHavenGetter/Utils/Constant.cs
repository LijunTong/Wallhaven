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
                }
            };
    }
}
