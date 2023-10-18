﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void IncreaseGameScore()
        {
            // увеличить gameScore на 1
            gameScore++;
            Console.Title = $"{gameScore}";
        }
        private static void DecreaseGameScore()
        {
            gameScore--;
            Console.Title = $"{gameScore}";
            if (gameScore < 0)
            {
                GameOver();
                Console.WriteLine($"GameOver :(");
            }
        }
    }
}
