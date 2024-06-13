using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Helpers
{
    public static class IntExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsContainDigit(this string text)
        {
            foreach(char item in text)
            {.
                if (char.IsDigit(item))
                    return true;
            }
            return  false;
        }


    }
}
