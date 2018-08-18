using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingoConsole;
using BingoConsolePlayers;

namespace BingoConsoleNumbers
{
    public class BingoNumbers
    {
        public List<int> RandomBingo = new List<int>();
        Random num = new Random();
        Player person = new Player();

        public void randomNumbers()
        {
            while (RandomBingo.Count < 10)
            {
                int rnd = num.Next(1, 20);
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    if (!RandomBingo.Contains(rnd))
                    {
                        RandomBingo.Add(rnd);
                        Console.WriteLine(rnd);
                    }
                }
            }

        }
    }
}
