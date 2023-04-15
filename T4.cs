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

            int L = Convert.ToInt32(Console.ReadLine());

            int H = Convert.ToInt32(Console.ReadLine());

            int W = Convert.ToInt32(Console.ReadLine());

            double show = calc(L, H, W);

            Console.WriteLine(show);

        }//end Main



        private static double calc(int nam1, int nam2, int nam3)

        {

            double Resvlt = nam1 * nam2 * nam3;

            return Resvlt;

        } // end function

    }// end class

}// end namespace