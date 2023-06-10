using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class MathOp
    {
        public static string plus(string a, string b)
        {
            return Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b));


        }
        public static string minus(string a, string b)
        {
            return Convert.ToString(Convert.ToDouble(b) - Convert.ToDouble(a));
        }
        public static string multiplication(string a, string b)
        {
            return Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b));
        }
        public static string division(string a, string b)
        {
            return Convert.ToString(Convert.ToDouble(b) / Convert.ToDouble(a));
        }
        public static string percent(string a, string b)
        {
            return Convert.ToString(Convert.ToDouble(b) / 100 * Convert.ToDouble(a));
        }
        public static string plusMinusA(string a)
        {
            return Convert.ToString(-1 * Convert.ToDouble(a));
        }

        public static string oneDivisionX(string x)
        {
            return Convert.ToString(Convert.ToDouble(1) / Convert.ToDouble(x));
        }

        public static string squareX(string x)
        {
            return Convert.ToString(Convert.ToDouble(x) * Convert.ToDouble(x)); ;
        }
        public static string sqrtX(string x)
        {
            return Convert.ToString(Math.Sqrt(Convert.ToDouble(x))); ;
        }


    }

}
