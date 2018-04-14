using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace StateIncomeSalesTotalTaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2002 State Income, Sales, and Total Tax & Rankings");

            WebClient client = new WebClient();

            //read the webpage and save the file (if none exists)
            string result = client.DownloadString("http://money.cnn.com/pf/features/lists/total_taxes/");
            string fileName = "CNN State Tax Info";

            string fileLocationExtension = "\\Users\\User";

            if (File.Exists(String.Format(@"C:{0}\Documents\Development\CNN Tax Info\{1}", fileLocationExtension, fileName)))
            {
                //Console.WriteLine("The file: {0}, already exists", fileName);
            }
            else
            {
                File.WriteAllText(String.Format(@"C:{0}\Documents\Development\CNN Tax Info\{1}", fileLocationExtension, fileName), result);
                Console.WriteLine("{0} file was just created", fileName);
            }

            //var stateTaxInfo = new List<StateInfo>();
            StateInfo stateInfo = new StateInfo();
            string line;

            using (StreamReader file = new StreamReader(@"C:~\Documents\Development\CNN Tax Info\CNN State Tax Info"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("font-weight: bold"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        stateInfo.states.Add(line);
                    }
                    //PIT - Personal Income Tax
                    if (line.Contains("PIT"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        stateInfo.personalIncomeTax.Add(line);
                    }
                    //PTR - Personal Income Tax Rank
                    if (line.Contains("PTR"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        stateInfo.personalIncomeTaxRank.Add(line);
                    }
                    //STR - Sales Tax
                    if (line.Contains("ST\">"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        stateInfo.salesTax.Add(line);
                    }
                    //STR - Sales Tax Rank
                    if (line.Contains("SR\">"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        stateInfo.salesTaxRank.Add(line);
                    }
                    //TT - Total Tax
                    if (line.Contains("TT\">"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        stateInfo.totalTax.Add(line);
                    }
                    //TR - Total Tax Rank
                    if (line.Contains("TR\">"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        stateInfo.totalTaxRank.Add(line);
                    }
                }
            }

            Console.WriteLine("Would you like to see a complete list of state tax info?");
            string answer = Console.ReadLine();

            List<List<string>> stateTaxInfo = new List<List<string>>();

            for (int i = 0; i < stateInfo.states.Count; i++)
            {
                stateTaxInfo.Add(new List<string> {
                    stateInfo.states[i],
                    stateInfo.personalIncomeTax[i],
                    stateInfo.personalIncomeTaxRank[i],
                    stateInfo.salesTax[i],
                    stateInfo.salesTaxRank[i],
                    stateInfo.totalTax[i],
                    stateInfo.totalTaxRank[i]
                });
            }

            void Output(int stateIndex)
            {
                Console.WriteLine(
                        stateTaxInfo[stateIndex][0].ToString().PadRight(15) +
                        stateTaxInfo[stateIndex][1].PadRight(18) +
                        stateTaxInfo[stateIndex][2].PadRight(8) +
                        stateTaxInfo[stateIndex][3].PadRight(10) +
                        stateTaxInfo[stateIndex][4].PadRight(9) +
                        stateTaxInfo[stateIndex][5].PadRight(11) +
                        stateTaxInfo[stateIndex][6]
                        );
            }

            if (answer.ToLower() == "yes" || answer.ToLower() == "y")
            {
                Console.WriteLine("* State * Personal Income Tax * Rank * Sales Tax * Rank * Total Tax * Rank *");

                for (int i = 0; i < stateInfo.states.Count; i++)
                {
                    Output(i);
                }
            }

            Console.WriteLine("Would you like to compare states?");
            string compareStatesAnswer = Console.ReadLine();

            if (compareStatesAnswer.ToLower() == "yes" || compareStatesAnswer.ToLower() == "y")
            {
                Console.WriteLine("How many states?");
                int numberOfStates = int.Parse(Console.ReadLine());

                int i = 0;
                while (i < numberOfStates)
                {
                    Console.WriteLine("Pick a state");
                    string stateSelection = Console.ReadLine();

                    for (int k = 0; k < stateInfo.states.Count; k++)
                    {
                        var state = stateTaxInfo[k][0].ToString();

                        if (stateSelection.ToLower() == state.ToLower())
                        {
                            Output(k);
                        }
                    }
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
