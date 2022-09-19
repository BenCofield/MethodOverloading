using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool inDollars)
        {
            int sum = x + y;
            string str = Convert.ToString(sum);
            if (inDollars == true)
            {
                str += " dollar";
                if (sum > 1)
                {
                    str += "s";
                }
            }
            return str;
        }
    }
}
