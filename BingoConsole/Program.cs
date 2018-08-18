using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingoConsolePlayers;
using BingoConsoleNumbers;


namespace BingoConsole
{
    public class Program
    {
        public static void Main()
        {
            Player nameOfPlayer = new Player();
            BingoNumbers randomise = new BingoNumbers();

            Console.WriteLine("What's your name?");
            nameOfPlayer.player = Console.ReadLine();

            Console.WriteLine("Welcome to Bingo " + nameOfPlayer.player);

            Console.WriteLine("In this Bingo game, you only have to match 5, when you're ready for the numbers press space!");


            
            nameOfPlayer.matchingNumbers = new List<int>();

            Console.WriteLine("Your numbers are: \n");
            for (int k = 0; k < nameOfPlayer.setOfNumbers.Length; k++)
            {
                Console.Write(nameOfPlayer.setOfNumbers[k] + ", ");
            }
            Console.WriteLine("\n" + "\n");
            randomise.randomNumbers();
            

            for (int i = 0; i < randomise.RandomBingo.Count; i++)
            {
                for (int j = 0; j < nameOfPlayer.setOfNumbers.Length; j++)
                {
                    if (randomise.RandomBingo[i] == nameOfPlayer.setOfNumbers[j])
                    {
                        nameOfPlayer.matchingNumbers.Add(nameOfPlayer.setOfNumbers[j]);

                    }
                    // randomise.RandomBingo.Sort();
                    // Console.WriteLine(randomise.RandomBingo[i]);
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < nameOfPlayer.matchingNumbers.Count; i++)
            {
                Console.WriteLine("Match of " + nameOfPlayer.matchingNumbers[i]);
            }

            if (nameOfPlayer.matchingNumbers.Count == nameOfPlayer.setOfNumbers.Length)
            {
                Console.WriteLine("Bingo");
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
            // Console.Write("Play again?");
            Console.ReadLine();
        }
    }
}
