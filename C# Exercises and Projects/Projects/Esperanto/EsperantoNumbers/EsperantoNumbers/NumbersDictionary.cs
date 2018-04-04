using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsperantoNumbers
{
    public class NumbersDictionary
    {

        public long UserInput()
        {
            Console.WriteLine("Input a number: ");
            long userInput = long.Parse(Console.ReadLine());
            return userInput;
        }

        public string NumbersToWords()
        {
            string userInput = UserInput().ToString();
            //Esperanto base numbers
            var esperantoNumsDict = new Dictionary<string, string>()
            {
                { "0", "nulo" },
                { "1", "unu" },
                { "2", "du" },
                { "3", "tri" },
                { "4", "kvar" },
                { "5", "kvin" },
                { "6", "ses" },
                { "7", "sep" },
                { "8", "ok" },
                { "9", "nau" },
                { "10", "dek"},
                { "100", "cent"},
                { "1000", "mil"},
                { "1000000", "miiono"},
                { "1000000000", "milionardo"},
                { "1000000000000", "bilionardo"}
            };

            var keys = esperantoNumsDict.Keys;
            var values = esperantoNumsDict.Values;

            //take user input and convert to characters
            char[] userInputConvertToString = userInput.ToString().ToCharArray();

            foreach (var num in userInputConvertToString)
            {
                //convert each character digit to a string
                var numString = num.ToString();
                foreach (var key in keys)
                {
                    var stringKey = key.ToString();
                    if (numString == stringKey)
                    {
                        var stringValue = values.ToString();
                        Console.WriteLine(numString + " is " + esperantoNumsDict[stringKey]);
                    }
                }
            }
            Console.ReadKey();

            return null;
        }
    }
}
