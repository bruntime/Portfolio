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
                        double personalIncomeTax = double.Parse(line);
                        stateInfo.personalIncomeTax.Add(personalIncomeTax);
                    }
                    //PTR - Personal Income Tax Rank
                    if (line.Contains("PTR"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        int personalIncomeTaxRank = int.Parse(line);
                        stateInfo.personalIncomeTaxRank.Add(personalIncomeTaxRank);
                    }
                    //STR - Sales Tax
                    if (line.Contains("ST\">"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        double salesTax = double.Parse(line);
                        stateInfo.salesTax.Add(salesTax);
                    }
                    //STR - Sales Tax Rank
                    if (line.Contains("SR\">"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        int salesTaxRank = int.Parse(line);
                        stateInfo.salesTaxRank.Add(salesTaxRank);
                    }
                    //TT - Total Tax
                    if (line.Contains("TT\">"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        double totalTax = double.Parse(line);
                        stateInfo.totalTax.Add(totalTax);
                    }
                    //TR - Total Tax Rank
                    if (line.Contains("TR\">"))
                    {
                        line = line.Split('>', '/')[1];
                        line = line.TrimEnd('<');
                        int totalTaxRank = int.Parse(line);
                        stateInfo.totalTaxRank.Add(totalTaxRank);
                    }
                }
            }

            Console.WriteLine("* State * Personal Income Tax * Rank * Sales Tax * Rank * Total Tax * Rank *");

            for (int i = 0; i < stateInfo.states.Count; i++)
            {
                Console.WriteLine(stateInfo.states[i].PadRight(15) +
                    stateInfo.personalIncomeTax[i].ToString().PadRight(18) +
                    stateInfo.personalIncomeTaxRank[i].ToString().PadRight(8) + 
                    stateInfo.salesTax[i].ToString().PadRight(10) +
                    stateInfo.salesTaxRank[i].ToString().PadRight(9) +
                    stateInfo.totalTax[i].ToString().PadRight(11) +
                    stateInfo.totalTaxRank[i]);
            }

            Console.ReadKey();
        }
    }
}
