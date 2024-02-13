using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_work
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int i = 4;
            double d = 4.0;
            string s = "Polyilaro ";

            //Declare second integer, double, and String variables.
            int secondInteger;
            double secondDouble;
            string secondString;

            // Read and save an integer, double, and String to your variables.
            Console.WriteLine("Enter an integer value");
            secondInteger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an double value");
            secondDouble = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a string message");
            secondString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + secondInteger);

            // Print the sum of the double variables on a new line.
            double doubleSum = d + secondDouble;
            Console.WriteLine(Math.Round(doubleSum, 1));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + secondString); //ssss + bbb = ssssbbb
            Console.ReadLine();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        }
    }
}
