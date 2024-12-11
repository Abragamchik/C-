﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    internal class Test_4
    {
         public void Task_4()
          {
            // Ініціалізація масиву Х (змінюйте 5 на останню цифру зі списку групи)
            int n = 10 + 5;
            int[] X = new int[n];

            // Заповнення масиву випадковими значеннями
            Random rand = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(-50, 51); // Випадкові числа від -50 до 50
            }

            // Введення числа М
            Console.Write("Введіть число M: ");
            int M = int.Parse(Console.ReadLine());

            // Формування масиву Y
            int[] Y = X.Where(x => Math.Abs(x) > M).ToArray();

            // Вивід результатів
            Console.WriteLine("Масив X: " + string.Join(", ", X));
            Console.WriteLine("Число M: " + M);
            Console.WriteLine("Масив Y: " + string.Join(", ", Y));

         }
    }
}