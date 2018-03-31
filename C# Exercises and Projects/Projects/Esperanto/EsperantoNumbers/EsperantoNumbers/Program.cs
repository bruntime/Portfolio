using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsperantoNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public string NumbersToWords()
        {
            var esperantoNumsDict = new Dictionary<char, string>()
            {
                { '0', "nulo" },
                { '1', "unu" },
                { '2', "du" },
                { '3', "tri" },
                { '4', "kvar" },
                { '5', "kvin" },
                { '6', "ses" },
                { '7', "sep" },
                { '8', "ok" },
                { '9', "nau" }
            };

            var userNum = 394023235;

            var keys = esperantoNumsDict.Keys;
            var values = esperantoNumsDict.Values;

            //convert user input to character array
            var testNumArray = userNum.ToString().ToCharArray();

            //compare each individual digit with keys in numbers dictionary, return appropriate value
            //for example, 19380 returns unu nau tri ok nulo (in order)
            foreach (var num in testNumArray)
            {
                foreach (var key in keys)
                {
                    if (num == key)
                    {
                        Console.WriteLine("value: " + esperantoNumsDict[key]);
                    }
                }
            }
            return null;
        }
    }
}
