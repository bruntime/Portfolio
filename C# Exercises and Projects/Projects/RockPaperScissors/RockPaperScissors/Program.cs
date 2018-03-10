using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rounds are you playing?");
            int userRounds = int.Parse(Console.ReadLine());
            int totalRounds = 0;
            while (totalRounds < userRounds)
            {
                totalRounds++;
                Console.WriteLine("Total Rounds = " + userRounds + ", Current Round: " + totalRounds);

                Console.WriteLine("Rock, Paper, or Scissors?");
                string option = Console.ReadLine();

                if (option.ToLower() == "rock")
                {
                    Console.WriteLine("Rock beats scissors");
                }
                if (option.ToLower() == "scissors")
                {
                    Console.WriteLine("Scissors beat paper");
                }
                if (option.ToLower() == "paper")
                {
                    Console.WriteLine("Paper beats rock");
                }
                else
                {
                    Console.WriteLine("You did not select rock, paper, or scissors");
                }
            }
            Console.WriteLine("Thanks for playing Rock Paper Scissors.");
        }
    }
}
