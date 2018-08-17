using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BingoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            BingoNumbers randomise = new BingoNumbers();
            Player nameOfPlayer = new Player();

            Console.WriteLine("What's your name?");
            nameOfPlayer.player = Console.ReadLine();

            Console.WriteLine("Welcome to Bingo " + nameOfPlayer.player);

            Console.WriteLine("In this Bingo game, you only have to match 5 of the 10 numbers, choose numbers from 1 to 25");


            nameOfPlayer.setOfNumbers = new int[] { 3, 7, 14, 19, 23, 11, 2, 32 };

            randomise.randomNumbers();

            for (int i = 0; i < randomise.RandomBingo.Count; i++)
            {
                for (int j = 0; j < nameOfPlayer.setOfNumbers.Length; j++)
                {
                    if (randomise.RandomBingo[i] == nameOfPlayer.setOfNumbers[j])
                    {
                        Console.WriteLine("We have a match " + nameOfPlayer.setOfNumbers[j]);  
                    }
                }
                randomise.RandomBingo.Sort();
                Console.WriteLine(randomise.RandomBingo[i]);
            }


            Console.ReadLine();

            //Create 5 arrays with different numbers within an array and loop through to check with || to make sure all numbers are random. 
            // populate the number first instead of user input
        }
    }
}
