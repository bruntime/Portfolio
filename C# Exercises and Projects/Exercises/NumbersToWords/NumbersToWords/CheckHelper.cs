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
            //for each number from 0 - 9, replace with word
            //if num is equal to 0 replace with "zero"
            //for 1 replace with "one"
            //for 2 replace with "two"
            //return each value
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

        public string ConvertNumbersToWords(decimal num)
        {
            return null;
            //10 - 19
            //20 - 99
            //100 - 999
            //1000 - 9999
        }
    }
}
