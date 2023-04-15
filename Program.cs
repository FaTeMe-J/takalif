using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Test1
    {
        static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Even(x);
            }
            else { odd(x); }
        }
        static int Even(int x)
        {
            int sum = 0, zarb = 1;
            for (int i = 2; i < 2; i++)
            {
                sum += i;
                zarb *= i;
                Console.WriteLine("majmoe" + sum);
                Console.WriteLine("haselzarb" + zarb);
            }
        }
            static int odd(int x)
            {
                int sum = 0, zarb = 1;
                for (int i = 1; i <= x; i++)
                {
                    sum += i;
                    zarb *= i;
                    Console.WriteLine("majmoe" + sum);
                    Console.WriteLine("haselzarb" + zarb);
                }
            }
        
    }
}