using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ItSelf
{
    public record Request(string Path, HttpMethod Method);
    internal class RequestParser
    {
        public static Request Parse(string header)
        {
            var split = header.Split(' ');
            return new Request(split[1], GetMethod(split[0]));
        }

        private static HttpMethod GetMethod(string method)
        {
            if (method == "GET")
            {
                return HttpMethod.Get;
            }
            return HttpMethod.Post;
        }
    }
}
