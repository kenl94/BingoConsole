using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoConsolePlayers
{
    class Player
    {
        public string player { get; set; }

        public int[] setOfNumbers = new int[] { 3, 7, 13, 15, 19 };
        public List<int> matchingNumbers;


    }
}


  
  //public string player { get; set; }
  //      public static Random playerRandomNum = new Random();
  //      public static int[,] setOfNumbers = new int[5, 5];
  //      public List<int> matchingNumbers;

  //      public static void populateBingoCard()
  //      {
  //          int inum = 0;
  //          while (inum < 100)
  //          {

  //              for (int i = 0; i < setOfNumbers.GetLength(0); i++)
  //              {
  //                  for (int j = 0; j < setOfNumbers.GetLength(1); j++)
  //                  {
  //              int setPlayerNums = playerRandomNum.Next(1, 75);
  //                      setOfNumbers[i, j] = setPlayerNums;
  //                  }
  //              };

  //              inum++;
  //          }
  //      }
 
 
