using System;
using System.Net;
using System.IO;
using System.Collections.Generic;


namespace StateIncomeSalesTotalTaxApp
{
    class Program
    {
        //constants for string text that will be parsed later for state values
        private const string openCloseTD = "<td class=\"tease\" style=\"font-weight: bold;\">Alabama</td>";

        static void Main(string[] args)
        {
            //heading
            Console.WriteLine("State Income, Sales, and Total Tax & Rankings");
            Console.WriteLine(openCloseTD);
            //get state list and add it to an array / list
            //http://money.cnn.com/pf/features/lists/total_taxes/
            string sub = openCloseTD.Substring(45); //check if the text contained after substring is a state
            Console.WriteLine("test: " + sub);

            WebClient client = new WebClient();

            //read the webpage
            string result = client.DownloadString("http://money.cnn.com/pf/features/lists/total_taxes/");

            //save the webpage
            File.WriteAllText(@"C:~\Documents\Development\CNN Tax Info\CNN State Tax Info", result);
           
            List<string> stateList = new List<string>();

            //if text between < td class="tease" style="font-weight: bold;">Alabama</td>
            //save the state to stateList


            //get user to select a state


            //after user selects a state and clicks enter
            //display the results received from website
            //http://money.cnn.com/pf/features/lists/total_taxes/

            //if user types a state that doesn't exist,
            //display an error message

            //user can reset state selection and try again

            //user can quit

            Console.ReadKey();

        }
    }
}
