using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ones = new string[] { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = new string[] { "zero","ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int number = 0;
            string words = string.Empty;

            do
            {
                Console.Write("Input: ");
                number = int.Parse(Console.ReadLine());

                if (number < 20 )
                {
                    words = ones[number];
                    Console.WriteLine("Output: " + words);
                }
                else if (number % 10 == 0)
                {
                    words = tens[number/10];
                    Console.WriteLine("Output: " + words);
                }
                else
                {
                    words = tens[number / 10] +" "+ones[number % 10];
                    Console.WriteLine("Output: " + words);
                }
                
            } while (number != 999); // Just an input to stop the loop
        }

    }
}
