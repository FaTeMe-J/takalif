using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace J5_2
{

    class Program
    {
        static void Main(string[] args)
        {
            // create a 3x3 matrix
            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new double[,] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        });

            // calculate the determinant of the matrix
            double det = matrix.Determinant();

            Console.WriteLine("The determinant of the matrix is {0}", det);

            // calculate the inverse of the matrix
            Matrix<double> inverse = matrix.Inverse();

            Console.WriteLine("The inverse of the matrix is:");
            Console.WriteLine(inverse);

            Console.ReadKey();
        }
    }

}
