using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingoConsoleNumbers;
using BingoConsolePlayers;

namespace BingoConsole
{
    class WinCondition
    {
        Player name = new Player();
        BingoNumbers randomise = new BingoNumbers();

        public void Win()
        {
            Console.WriteLine("Your numbers are: \n");
            for (int k = 0; k < name.setOfNumbers.Length; k++)
            {
                Console.Write(name.setOfNumbers[k] + ", ");
            }
            Console.WriteLine("\n" + "\n");

            Console.WriteLine("Computers numbers are: \n");
            for (int i = 0; i < name.playerTwoNumbers.Length; i++)
            {
                Console.Write(name.playerTwoNumbers[i] + ", ");
            }

            Console.WriteLine("\n" + "\n");

            randomise.randomNumbers();

            name.playerMatchingNumbers = new List<int>();
            name.computerMatchingNumbers = new List<int>();

            for (int i = 0; i < randomise.RandomBingo.Count; i++)
            {
                for (int j = 0; j < name.setOfNumbers.Length; j++)
                {

                    if (randomise.RandomBingo[i] == name.setOfNumbers[j]) 
                    {
                        name.playerMatchingNumbers.Add(name.setOfNumbers[j]);
                    }

                    if (randomise.RandomBingo[i] == name.playerTwoNumbers[j])
                    {
                        name.computerMatchingNumbers.Add(name.playerTwoNumbers[j]);
                    }


                }
            }

            Console.WriteLine("");
            for (int i = 0; i < name.playerMatchingNumbers.Count; i++)
            {
                Console.WriteLine("You haved matched " + name.playerMatchingNumbers[i]);
            }

            for (int j = 0; j < name.computerMatchingNumbers.Count; j++)
            {
                Console.WriteLine("Computer has match of " + name.computerMatchingNumbers[j]);
            }

            if (name.playerMatchingNumbers.Count == name.setOfNumbers.Length)
            {
                Console.WriteLine("Bingo, You Win!");
            }
            else if (name.computerMatchingNumbers.Count == name.playerTwoNumbers.Length)
            {
                Console.WriteLine("Computer Bingo, Computer Wins!");
            }
            else
            {
                Console.WriteLine("No one won. Better luck next time!");
            }
        }
    }
}
