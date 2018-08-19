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
        public int[] playerTwoNumbers = new int[] { 2, 5, 16, 18, 23 };
        public List<int> matchingNumbers;
        public int[][] setOfNumbers2 = new int [5][];


    }
}
 
 
