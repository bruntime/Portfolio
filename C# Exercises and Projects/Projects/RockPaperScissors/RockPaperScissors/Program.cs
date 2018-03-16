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
            Random rnd = new Random();
            int userWins = 0;
            int computerWins = 0;
            int userComputerTies = 0;
            int disqualifiedRound = 0;

            Console.WriteLine("How many rounds would you like to play");
            int userRounds = int.Parse(Console.ReadLine());

            for (int totalRounds = 0; totalRounds < userRounds; totalRounds++)
            {
                string computerResponse = GenerateRandomNumber.ComputerResponse();

                //Ask the user to select a response - rock, paper, or scissors
                Console.WriteLine("Rock, Paper, or Scissors?");
                string userResponse = Console.ReadLine().ToLower();

                //Compare computer response to user response
                //if responses are tied
                if (userResponse == computerResponse)
                {
                    Console.WriteLine("User and computer are tied");
                    userComputerTies++;
                }
                else if (userResponse == "rock" && computerResponse == "paper" || userResponse == "paper" && computerResponse == "scissors" || userResponse == "scissors" && computerResponse == "rock")
                {
                    Console.WriteLine("user loses with: {0}, computer wins with {1}", userResponse, computerResponse);
                    computerWins++;
                }
                else if (userResponse == "rock" && computerResponse == "scissors" || userResponse == "paper" && computerResponse == "rock" || userResponse == "scissors" && computerResponse == "paper")
                {
                    Console.WriteLine("User wins with: {0}, computer loses with {1}" , userResponse, computerResponse);
                    userWins++;
                }
                //for all other responses
                else
                {
                    Console.WriteLine("No one wins because I don't know what you entered but it's not rock, paper or, scissors. " + userResponse + "? vs." + computerResponse);
                    disqualifiedRound++;
                }
            }
            Console.Write("TOTAL MATCHES: {0}, User Wins: {1}, Computer Wins {2}, Ties {3}, Disqualification(s): {4}", userRounds, userWins, computerWins, userComputerTies, disqualifiedRound);
            Console.ReadLine();
        }
    }
}
