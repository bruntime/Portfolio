using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class GenerateRandomNumber
    {
        public static string ComputerResponse()
        {
            Random randomNumber = new Random();
            int randomValue = randomNumber.Next(1, 4);
            string computerChoice;

            //convert generated number to rock, paper, or scissors
            if (randomValue == 1)
            {
                computerChoice = "rock";
            }
            else if (randomValue == 2)
            {
                computerChoice = "paper";
            }
            else
            {
                computerChoice = "scissors";
            }
            return computerChoice;
        }
    }
}
