using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    internal class Test_1
    {
       
            public void practical_1()
            {
                int studentNumber = 1;
                int upperLimit = 10 + studentNumber;

                Console.WriteLine("Введіть три числа:");
                int[] numbers = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Число {i + 1}: ");
                    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                    {
                        Console.Write($"Введіть коректне число для числа {i + 1}: ");
                    }
                }

                Console.WriteLine($"Числа, що належать інтервалу [1, {upperLimit}]:");
                foreach (int number in numbers)
                {
                    if (number >= 1 && number <= upperLimit)
                    {
                        Console.WriteLine(number);
                    }
                }
            }

        
    }
}
