using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J5_1
{

    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[50, 50];

            // fill the array with random values
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    arr[i, j] = rand.Next(100);
                }
            }

            // find the median of the array
            int median = QuickSelect(arr, 0, 49, 24);

            Console.WriteLine("The median of the array is {0}", median);

            Console.ReadKey();
        }

        static int QuickSelect(int[,] arr, int left, int right, int k)
        {
            if (left == right)
            {
                return arr[left, k];
            }

            int pivotIndex = left + (right - left) / 2;
            pivotIndex = Partition(arr, left, right, pivotIndex, k);

            if (k == pivotIndex)
            {
                return arr[pivotIndex, k];
            }
            else if (k < pivotIndex)
            {
                return QuickSelect(arr, left, pivotIndex - 1, k);
            }
            else
            {
                return QuickSelect(arr, pivotIndex + 1, right, k);
            }
        }

        static int Partition(int[,] arr, int left, int right, int pivotIndex, int k)
        {
            int pivotValue = arr[pivotIndex, k];
            Swap(arr, pivotIndex, right);

            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                if (arr[i, k] < pivotValue)
                {
                    Swap(arr, i, storeIndex);
                    storeIndex++;
                }
            }

            Swap(arr, storeIndex, right);

            return storeIndex;
        }

        static void Swap(int[,] arr, int i, int j)
        {
            for (int k = 0; k < 50; k++)
            {
                int temp = arr[i, k];
                arr[i, k] = arr[j, k];
                arr[j, k] = temp;
            }
        }
    }
}
