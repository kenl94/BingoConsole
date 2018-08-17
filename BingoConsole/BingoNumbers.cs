using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoConsole
{
   public class BingoNumbers
    {
        public List<int> RandomBingo = new List<int>();
        Random num = new Random();

        public void randomNumbers()
        {
            while (RandomBingo.Count < 50)
            {
                int rnd = num.Next(1, 100);

                if (!RandomBingo.Contains(rnd))
                {
                    RandomBingo.Add(rnd);
                }

            }


        }
    }
}
