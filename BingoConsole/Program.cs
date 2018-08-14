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
            // Find out the Users Name
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            // Name is found, says hello
            Console.WriteLine("Welcome to Bingo " + name);

            // Random Number
            Random num = new Random();

            Console.WriteLine("In this Bingo game, you only have to match 5 of the 10 numbers, choose numbers from 1 to 25");

            string[] playersChoices = new string[5]; 



            List<int> RandomBingo = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int rnd = num.Next(0, 25);
                Console.WriteLine(rnd);
                RandomBingo.Add(rnd);
            }
            
            int[] RandomNumArray = RandomBingo.ToArray();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("1st number is " + RandomNumArray[i]);
            }

            Console.ReadLine();



        }
    }
}
