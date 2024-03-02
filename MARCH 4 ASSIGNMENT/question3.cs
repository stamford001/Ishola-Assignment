using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Enter a sring");
            word = Console.ReadLine();

            char[] reverseArray = word.ToCharArray();

            Array.Reverse(reverseArray);
            string reverseWord = new string(reverseArray);

            Console.WriteLine(reverseWord);
        }
    }
}