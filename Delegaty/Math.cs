using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    static class Math
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        public static int AddWithResult(int a, int b)
        {
            return a + b;
        }

        public static bool IsDividePossible(int a, int b)
        {
            if (a % b == 0)
                return true;

            return false;
        }
    }
}
