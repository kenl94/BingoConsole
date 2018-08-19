using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoConsolePlayers
{
    class Player
    {

        Random number = new Random();

        public string player { get; set; }
        public int[] setOfNumbers = new int[] { 3, 5, 7, 9, 13 };
        public int[] playerTwoNumbers = new int[] { 2, 5, 8, 11, 14 };
        public List<int> playerMatchingNumbers;
        public List<int> computerMatchingNumbers;
        public int[][] setOfNumbers2 = new int [5][];


        public void getName()
        {
            Console.WriteLine("What's your name?");
            player = Console.ReadLine();

            Console.WriteLine("Welcome to Bingo " + player);


            Console.WriteLine("In this Bingo game, you only have to match 5, when you're ready for the numbers press space!");
        }

        //public void jaggedArray()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 5; j++)
        //        {
        //            int oneToFifteen = number.Next(1, 15);
        //            int sixteenToThirty = number.Next(16, 30);
        //            int thirtyOneToFourtyFive = number.Next(31, 45);
        //            int fourtySixToSixty = number.Next(46, 60);
        //            int sixtyOneToSeventyFive = number.Next(61, 75);

        //            setOfNumbers2[i] = new int[5] { oneToFifteen, sixteenToThirty, thirtyOneToFourtyFive, fourtySixToSixty, sixtyOneToSeventyFive };

        //            Console.Write(setOfNumbers2[i][j] + ",");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
 
 
