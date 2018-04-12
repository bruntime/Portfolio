using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace StateIncomeSalesTotalTaxApp
{
    class Program
    {
        private const string stateDataCell = "<td class=\"tease\" style=\"font-weight: bold;\">";

        static void Main(string[] args)
        {
            Console.WriteLine("State Income, Sales, and Total Tax & Rankings");

            WebClient client = new WebClient();

            //read the webpage and save the file (if none exists)
            string result = client.DownloadString("http://money.cnn.com/pf/features/lists/total_taxes/");
            string fileName = "CNN State Tax Info";

            if (File.Exists(String.Format(@"C:~\Documents\Development\CNN Tax Info\{0}", fileName)))
            {
                Console.WriteLine("The file: {0}, already exists", fileName);
            }
            else
            {
                File.WriteAllText(String.Format(@"C:~\Documents\Development\CNN Tax Info\{0}", fileName), result);
                Console.WriteLine("{0} file was just created", fileName);
            }

            List<string> states = new List<string>();
            string line;

            using (StreamReader file = new StreamReader(@"C:~\Documents\Development\CNN Tax Info\CNN State Tax Info"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(stateDataCell))
                    {
                        states.Add(line);
                    }
                }
            }

            foreach (var state in states)
            {
                Console.WriteLine(state);
            }

            Console.ReadKey();

        }
    }
}
