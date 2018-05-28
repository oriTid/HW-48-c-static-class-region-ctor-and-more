using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    static class Calc
    {
        static Calc()
        {
            Console.WriteLine($"Calcualtor was used here @ { DateTime.Now.ToLongDateString()} { DateTime.Now.ToLongTimeString()}");
        }

        #region static functions
        public static int GetSub(int x, int y)
        {
            return x + y;
        }

        public static int GetSub(int x, int y, int z)
        {
            return x + y + z;
        }

        public static int GetSub(double x, double y)
        {
            return Convert.ToInt32(x + y);
        }

        #endregion
    }
}
