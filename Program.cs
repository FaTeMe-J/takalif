using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace box_info

{
    class test1

    {

        public static void Main()

        {
            int x=Convert.ToInt32(Console.ReadLine());

             calc(x);
        }
        static void calc(int x)
        {
            double result = Math.Pow(x, 2) + (2 * x) - 4;
            Console.WriteLine(result); 
        }
    }
}
