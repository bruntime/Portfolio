using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.multiples_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem: Multiples of 3 and 5 - https://projecteuler.net/problem=1

            // If we list all the natural numbers below 10 that are multiples of 3 or 5, 
            // we get 3, 5, 6 and 9. The sum of these multiples is 23.

            // Find the sum of all the multiples of 3 or 5 below 1000.

            IEnumerable<int> numTo1000 = Enumerable.Range(1, 999);

            int sumNumDivisibleBy3Or5 = 0;

            foreach (int num in numTo1000)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    sumNumDivisibleBy3Or5 += num;
                }
            }
            Console.WriteLine("Sum of all multiples of 3 or 5 below 1000: " + sumNumDivisibleBy3Or5);
        }
    }
}
