using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }

            else if (number == 0)
            {
                Console.WriteLine("Number is zero");
            }

            else
            {
                Console.WriteLine("Number is negative");
            }
        }
    }
}