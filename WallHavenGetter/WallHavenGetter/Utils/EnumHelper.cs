using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Utils
{
    public class EnumHelper
    {
        /// <summary>
        /// 获取枚举值上的描述
        /// </summary>
        /// <param name="t">枚举类型</param>
        /// <param name="val">枚举值</param>
        /// <returns>枚举元素上面的描述</returns>
        public static string GetEnumDesp(Type t, int val)
        {
            string value = "";

            if (t.IsEnum && Enum.IsDefined(t, val))
            {
                Object enumObj = Enum.Parse(t, val.ToString());
                FieldInfo field = t.GetField(enumObj.ToString());

                if (field.IsDefined(typeof(DescriptionAttribute)))
                {
                    DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    value = attr.Description;
                }
            }

            return value;
        }

        /// <summary>
        /// 枚举类型转换为List
        /// </summary>
        /// <param name="t"></param>
        /// <returns>返回包含键(Key)、值(Value)、描述(Desp)的元素集合</returns>
        public static List<dynamic> EnumToList(Type t)
        {
            List<dynamic> enumList = new List<dynamic>();

            if (t.IsEnum)
            {
                foreach (var v in t.GetEnumValues())
                {
                    Object obj = Enum.Parse(t, v.ToString());
                    enumList.Add(new
                    {
                        Key = obj.ToString(),
                        Value = (int)v,
                        Desp = GetEnumDesp(t, (int)v)
                    });
                }
            }

            return enumList;
        }


        public static Dictionary<int, String> EnumDesps(Type t)
        {
            Dictionary<int, String> dict = new Dictionary<int, String>();

            if (t.IsEnum)
            {
                foreach (var v in t.GetEnumValues())
                {

                    dict.Add((int)v, GetEnumDesp(t, (int)v));
                }
            }
            return dict;
        }
    }
}
