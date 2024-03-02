using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter number " + (i +1) );
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);


            Console.WriteLine("Numbers in ascending order");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}