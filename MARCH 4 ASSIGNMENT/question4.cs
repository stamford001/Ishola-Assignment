using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row size");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter column size");
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[row, column];
            Random random = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(10, 99);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}