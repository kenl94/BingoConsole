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
            List<int> RandomBingo = new List<int>();
            Random num = new Random();

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome to Bingo " + name);

            Console.WriteLine("In this Bingo game, you only have to match 5 of the 10 numbers, choose numbers from 1 to 25");

            //string[,] playersChoices = new string[5,5];
            //int[,] playersNummbers = Int32.Parse(playersChoices);

            List<int> playerBingoCard = new List<int>();
            Console.WriteLine("Please select 5 number which will go in the order you have input for the first row");
            string[] input1 = Console.ReadLine().Split(',');


            for (int i = 0; i < input1.Length; i++)
            {
                playerBingoCard.Add(Int32.Parse(input1[i]));
                if (input1.Length > 5)
                {
                    Console.WriteLine("You've entered too many numbers");
                }
            }
            for (int i = 0; i < playerBingoCard.Count; i++)
            {
                Console.WriteLine("number in the grid is as follows from left to right " + playerBingoCard[i]);
            }


            while (RandomBingo.Count < 10)
            {
                int rnd = num.Next(1, 25);
                if (!RandomBingo.Contains(rnd))
                {
                    RandomBingo.Add(rnd);
                    Console.WriteLine(rnd);
                }

            }
            // If you want to see if the numbers are all different
            RandomBingo.Sort();
            for (int i = 0; i < RandomBingo.Count; i++)
            {
                Console.WriteLine("Number is " + RandomBingo[i]);
                for (int j = 0; j < playerBingoCard.Count; j++)
                {
                    if (RandomBingo[i] == playerBingoCard[j])
                    {
                        Console.WriteLine("Players number " + playerBingoCard[j]);
                    }
                }
            }


            Console.ReadLine();


        }
    }
}
