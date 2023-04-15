using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number1:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Number2:");
            int b = int.Parse(Console.ReadLine());
            int flag = 0, z = 0, i = 1;
            while (flag != 1)
            {
                z = a * i;
                if (z % b == 0)
                    flag = 1;
                i++;
            }
            Console.WriteLine("K.m.m ={0}", z);
            while (b != 0)
            {
                int c = a % b;
                if (c == 0)
                    Console.WriteLine("B.m.m={0}", b);
                else
                    a = b;
                b = c;
            }
        }
    }
}