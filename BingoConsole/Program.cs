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
            // Find out the Users Name
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            // Name is found, says hello
            Console.WriteLine("Welcome to Bingo " + name);

            // Random Number

            Console.WriteLine("In this Bingo game, you only have to match 5 of the 10 numbers, choose numbers from 1 to 25");

            //string[,] playersChoices = new string[5,5];
            //int[,] playersNummbers = Int32.Parse(playersChoices);

            List<int> playerBingoCard = new List<int>() { 3, 11, 13, 17, 23 };

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
                Console.WriteLine("Number is "+ RandomBingo[i]);
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
