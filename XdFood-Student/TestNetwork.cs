using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XdFood_Student
{
    public static class TestNetwork
    {
        public static string Login(string un, string pd)
        {
            if (un != null && pd != null)
            {
                return "OK";
            }
            else
            {
                return "";
            }
        }
    }
}
