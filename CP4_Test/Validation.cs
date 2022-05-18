using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP4_Test
{
    internal static class Validation
    {
        private static string UserName = "admin";
        private static string Password = "pass";


        public static bool login(string username, string pass)
        {
            if (username == UserName && pass == Password) return true;
            return false;
        }


    }
}
