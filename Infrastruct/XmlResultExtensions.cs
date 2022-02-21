using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumDev.HotelsWebAPI.Infrastruct
{
    static public class XmlResultExtensions
    {
        public static IResult Xml<T>(this IResultExtensions _, T result) =>
            new XmlResult<T>(result);
    }
}
