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
            WinCondition WinOrLose = new WinCondition();
            Random number = new Random();
            Console.WriteLine("What's your name?");
            nameOfPlayer.player = Console.ReadLine();

            Console.WriteLine("Welcome to Bingo " + nameOfPlayer.player);


            Console.WriteLine("In this Bingo game, you only have to match 5, when you're ready for the numbers press space!");
            for (int i = 0; i < 5; i++)
            {
                nameOfPlayer.setOfNumbers2[i] = new int[5] { number.Next(1, 15), number.Next(16, 30), number.Next(31, 45), number.Next(46, 60), number.Next(61, 75) };

                for (int j = 0; j < 5; j++)
                {
                    
                    Console.Write(nameOfPlayer.setOfNumbers2[i][j] + ",");
                }

                Console.WriteLine();

            }


            while (true)
            {

                WinOrLose.Win();


                Console.WriteLine("Type [Y] To play again, otherwise any other key to exit");

                string playagain = Console.ReadLine().ToUpper();

                if (playagain == "Y")
                {
                    Main();
                }
                else
                {
                    return;
                }

            }
        }
    }
}
