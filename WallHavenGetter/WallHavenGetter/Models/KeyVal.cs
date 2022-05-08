using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Models
{
    public class KeyVal
    {
        public string Display { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Display;
        }
    }
}
