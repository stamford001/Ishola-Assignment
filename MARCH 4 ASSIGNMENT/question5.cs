using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] alpha = new float[50];

            for (int i = 0; i < alpha.Length; i++)
            {
                if (i < 25)
                {
                    alpha[i] = i ^ 2;
                }
                else
                {
                    alpha[i] = i * 3;
                }

                if (i % 10 != 0)
                {
                    Console.Write(alpha[i] + " \t");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(alpha[i] + " \t");
                }
            }

            Console.WriteLine();
        }
    }
}