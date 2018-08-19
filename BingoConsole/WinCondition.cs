using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingoConsoleNumbers;
using BingoConsolePlayers;

namespace BingoConsole
{
    class WinCondition
    {
       Player name = new Player();
       BingoNumbers randomise = new BingoNumbers();
        


        public void Win()
        {
            Console.WriteLine("Your numbers are: \n");
            for (int k = 0; k < name.setOfNumbers.Length; k++)
            {
                Console.Write(name.setOfNumbers[k] + ", ");
            }
            Console.WriteLine("\n" + "\n");
            randomise.randomNumbers();

            name.matchingNumbers = new List<int>();

            for (int i = 0; i < randomise.RandomBingo.Count; i++)
            {
                for (int j = 0; j < name.setOfNumbers.Length; j++)
                {
                    if (randomise.RandomBingo[i] == name.setOfNumbers[j])
                    {
                        name.matchingNumbers.Add(name.setOfNumbers[j]);
                    }
                }
            }


            Console.WriteLine("");
            for (int i = 0; i < name.matchingNumbers.Count; i++)
            {
                Console.WriteLine("Match of " + name.matchingNumbers[i]);
            }

            if (name.matchingNumbers.Count == name.setOfNumbers.Length)
            {
                Console.WriteLine("Bingo");
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}

//Player name = new Player();
//BingoNumbers randomise = new BingoNumbers();
//int[,] bingoCard = Player.setOfNumbers;

//public void Win()
//{

//    Console.WriteLine("Your numbers are: \n");
//    for (int i = 0; i < bingoCard.GetLength(0); i++)
//    {
//        for (int j = 0; j < bingoCard.GetLength(1); j++)
//        {
//            Console.Write(bingoCard[i, j] + ", ");

//        }
//    }
//    Console.WriteLine("\n" + "\n");
//    randomise.randomNumbers();

//    name.matchingNumbers = new List<int>();

//    for (int i = 0; i < randomise.RandomBingo.Count; i++)
//    {
//        for (int j = 0; j < bingoCard.GetLength(0); j++)
//        {
//            for (int k = 0; k < bingoCard.GetLength(1); k++)
//            {
//                if (randomise.RandomBingo[i] == bingoCard[j, k])
//                {
//                    name.matchingNumbers.Add(bingoCard[j, k]);
//                }

//            }
//        }
//    }


//    Console.WriteLine("");
//    for (int i = 0; i < name.matchingNumbers.Count; i++)
//    {
//        Console.WriteLine("Match of " + name.matchingNumbers[i]);
//    }

//    if (name.matchingNumbers.Count == bingoCard.Length)
//    {
//        Console.WriteLine("Bingo");
//    }
//    else
//    {
//        Console.WriteLine("Better luck next time");
//    }
//}
