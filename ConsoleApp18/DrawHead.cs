﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void DrawHead()
        { 
        graphics.FillEllipse(System.Drawing.Brushes.Pink, snake[0][0], snake[0][1], 10, 10);
            // нарисовать красный круг размером 10 на 10 по координатам нулевой ячейки змейки
            if (snake.Count > 1)
        graphics.FillEllipse(System.Drawing.Brushes.Yellow, snake[1][0], snake[1][1], 10, 10);
        }  
    }
}
