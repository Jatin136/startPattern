using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to print star pattern");
            Console.Write("Enter the minimum number of stars: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum number of stars: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            int totalCountOfStars = 0;
            // outer loop iteration for printing upper pattern of stars
            // for instance from min = 2 till max = 5
            for(int i = min; i <= max; i++)
            {
                //number of spaces in each iteration
                //space on each iteration should decrease for instance
                //for max value of 5 and min value of 2 space should accommodate minimum number of stars
                for (int j = max-i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                // start printing stars from minimum number incrementing each time based on the value of i (outer loop) till outer loop value of i
                // is maxed out
                for (int k = i; k > 0; k--)
                {
                    totalCountOfStars++; // increement count of stars each time its printed
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // loop for printing bottom pattern of stars
            // we need to iterate through max-min number of times
            for (int l = 0; l < max - min; l++)
            {
                // print spaces depending upon the number of line
                // for instance one space for first outer iterartion, two space for 2nd iteration and so on
                for (int m = l; m >= 0; m--)
                {
                    Console.Write(" ");
                }
                // start with max-1 stars till max-min (value evaluated on each iteration)
                for (int n = max - 1; n > l; n--)
                {
                    totalCountOfStars++; // increement count of stars each time its printed
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("The total number of stars printed is {0}", totalCountOfStars);
            Console.Read(); // in order to stop the program from exiting by itself during debugging
        }
    }
}
