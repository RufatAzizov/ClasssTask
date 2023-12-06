using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3110.Extension
{
    internal static class Extension
    {
        public static bool CustomContains(this string value, char c)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == c)
                {
                    return true;
                }
            }
            return false;

        }



    }
}
