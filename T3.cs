using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            calc(x, y);
        }//end main
        static void calc(int x, int y)
        {
            double result = Math.Sqrt(Math.Abs(x) + Math.Pow(y,x));
            Console.WriteLine(result);
        }
    }
}
