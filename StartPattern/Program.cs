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
            Console.Write("Enter the minimum number of stars ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum number of stars ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // outer loop iteration 
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
                for (int k = i; k > 0; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //for (int l = 0; l < max - 1; l++)
            //{
            //    for (int m = l; m >= 0; m--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int n = max - 1; n > l; n--)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            Console.Read();
        }
    }
}
