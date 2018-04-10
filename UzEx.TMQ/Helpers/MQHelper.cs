using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzEx.TMQ.Helpers
{
    public static class MQHelper
    {
        public static string Encode(string s)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
        }

        public static string Decode(string s)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }

    }
}
