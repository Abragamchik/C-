using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    internal class Test_2
    {
        public void Task_2()
        {
            double a, b, c;

            // Введення сторін трикутника з перевіркою
            Console.Write("Введіть сторону a: ");
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Введіть коректне значення для сторони a: ");
            }

            Console.Write("Введіть сторону b: ");
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.Write("Введіть коректне значення для сторони b: ");
            }

            Console.Write("Введіть сторону c: ");
            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.Write("Введіть коректне значення для сторони c: ");
            }

            // Перевірка на існування трикутника
            if (a + b > c && a + c > b && b + c > a)
            {
                // Обчислення периметру
                double perimeter = perimeter_(a, b, c);
                Console.WriteLine($"Периметр трикутника: {perimeter}");


                double p = perimeter / 2;
                double area = Area(perimeter, a, b, c);
                Console.WriteLine($"Площа трикутника: {area:F2}");

                // Визначення виду трикутника за сторонами
                if (a == b && b == c)
                {
                    Console.WriteLine("Трикутник рівносторонній.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Трикутник рівнобедрений.");
                }
                else
                {
                    Console.WriteLine("Трикутник різносторонній.");
                }
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не може існувати.");
            }
        }
        private double perimeter_(double a, double b, double c)
        {
            double perimeter = a + b + c;
            return perimeter;
        }
        private double Area(double perimeter, double a, double b, double c)
        {
            double p = perimeter / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

    }
}
