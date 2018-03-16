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

            Console.WriteLine("How many rounds would you like to play");
            int userRounds = int.Parse(Console.ReadLine());

            for (int totalRounds = 0; totalRounds < userRounds; totalRounds++)
            {
                //Generate a random number to represent rock, paper, or scissors
                //rock = 1, paper = 2, scissors = 3
                int rockPaperOrScissors = rnd.Next(1, 4);
                string computerResponse;

                //convert generated number to rock, paper, or scissors
                if (rockPaperOrScissors == 1)
                {
                    computerResponse = "rock";
                }
                else if (rockPaperOrScissors == 2)
                {
                    computerResponse = "paper";
                }
                else
                {
                    computerResponse = "scissors";
                }

                Console.WriteLine("Rock, Paper, or Scissors?");
                string userResponse = Console.ReadLine().ToLower();
                
                Console.WriteLine("Rock Paper or Scissors: computer: ({0}) {1}, user: {2}", rockPaperOrScissors, computerResponse, userResponse);

                //Compare computer response to user response

                //if responses are tied
                if (userResponse == computerResponse)
                {
                    Console.WriteLine("User and computer are TIED");
                    userComputerTies++;
                }
                else if (userResponse == "rock" && computerResponse == "paper")
                {
                    //research error when using format: {0} {1}
                    //System.FormatException: 'Index (zero based) must be greater than or equal to zero and less than the size of the argument list.'
                    //Console.WriteLine("User loses with {0}, computer wins with: {1}", userResponse, computerResponse);
                    Console.WriteLine("User loses with: " + userResponse + " computer wins with: " + computerResponse);
                    computerWins++;
                }
                else if(userResponse == "rock" && computerResponse == "scissors")
                {
                    Console.WriteLine("User wins with: " + userResponse + " computer loses with " + computerResponse);
                    userWins++;
                }
                else if (userResponse == "paper" && computerResponse == "scissors")
                {
                    Console.WriteLine("User loses with: " + userResponse + " computer wins with: " + computerResponse);
                    computerWins++;
                }
                else if (userResponse == "paper" && computerResponse == "rock")
                {
                    Console.WriteLine("User wins with: " + userResponse + " computer loses with " + computerResponse);
                    userWins++;
                }
                else if (userResponse == "scissors" && computerResponse == "rock")
                {
                    Console.WriteLine("User loses with: " + userResponse + " computer wins with: " + computerResponse);
                    computerWins++;
                }
                else if (userResponse == "scissors" && computerResponse == "paper")
                {
                    Console.WriteLine("User wins with: " + userResponse + " computer loses with " + computerResponse);
                    userWins++;
                }
                //for all other responses
                else
                {
                    Console.WriteLine("No one wins because I don't know what you entered but it's not rock, paper or, scissors. " + userResponse + "? vs." + computerResponse);
                }               
            }
            Console.Write("TOTAL MATCHES: {0}, User Wins: {1}, Computer Wins {2}, Ties {3}", userRounds, userWins, computerWins, userComputerTies);
            Console.ReadLine();
        }
    }
}
