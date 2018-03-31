using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    public class CheckHelper
    {
        static void Main(string[] args) // static with a void (or int) return type
        {
        }

        public string ConvertZeroToNine(decimal num)
        {
            if (num == 0) return "zero";
            if (num == 1) return "one";
            if (num == 2) return "two";
            if (num == 3) return "three";
            if (num == 4) return "four";
            if (num == 5) return "five";
            if (num == 6) return "six";
            if (num == 7) return "seven";
            if (num == 8) return "eight";
            if (num == 9) return "nine";
        
            return null;
        }

        public string ConvertTenToNineteen(decimal num)
        {
            string[] tenToNineteen =
            {
                 "ten",
                 "eleven",
                 "twelve",
                 "thirteen",
                 "fourteen",
                 "fifteen",
                 "sixteen",
                 "seventeen",
                 "eighteen",
                 "nineteen"
            };

            return null;
        }

        public string ConvertTens(decimal num)
        {
            if (num == 20) return "twenty";
            if (num == 30) return "thirty";
            if (num == 40) return "forty";
            if (num == 50) return "fifty";
            if (num == 60) return "sixty";
            if (num == 70) return "seventy";
            if (num == 80) return "eighty";
            if (num == 90) return "ninety";

            return null;
        }

        public string ConvertNumbersToWords(decimal num)
        {
            if(num.ToString().Length == 1)
            {
                ConvertZeroToNine(num);
            }
            if(num.ToString().Length == 2)
            {
                if(num < 20)
                {
                    ConvertTenToNineteen(num);
      
                }
                else if(num >= 20) {
                    ConvertTens(num);
                }
            }
            return null;
        }
    }
}
