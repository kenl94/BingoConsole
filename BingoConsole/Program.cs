﻿using System;
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


            Console.WriteLine("What's your name?");
            nameOfPlayer.player = Console.ReadLine();

            Console.WriteLine("Welcome to Bingo " + nameOfPlayer.player);

            Console.WriteLine("In this Bingo game, you only have to match 5, when you're ready for the numbers press space!");

            WinOrLose.Win();

           // Console.Write("Play again?");


            Console.ReadLine();


        }
    }
}
