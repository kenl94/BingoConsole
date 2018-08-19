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
                for (int j = 0; j < 5; j++)
                {
                    int oneToFifteen = number.Next(1, 15);
                    int sixteenToThirty = number.Next(16, 30);
                    int thirtyOneToFourtyFive= number.Next(31, 45);
                    int fourtySixToSixty = number.Next(46, 60);
                    int sixtyOneToSeventyFive = number.Next(61, 75);

                    nameOfPlayer.setOfNumbers2[i] = new int[5] { oneToFifteen, sixteenToThirty, thirtyOneToFourtyFive, fourtySixToSixty, sixtyOneToSeventyFive };

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
