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
            BingoNumbers randomNumbers = new BingoNumbers();

            while (true)
            {
                nameOfPlayer.getName();
                nameOfPlayer.multi();
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
