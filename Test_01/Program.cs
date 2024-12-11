using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Test_01;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-Завдання_1");
        Console.WriteLine("2-Завдання_2");
        Console.WriteLine("3-Завдання_3");
        Console.WriteLine("4-Завдання_4");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
                case 1:
                {
                    Test_1 test_1 = new Test_1();
                    test_1.practical_1(); 
                    break;

                }
            case 2:
                { 
                    Test_2 test_2 = new Test_2();
                    test_2.Task_2();
                    break;
                }
                case 3:
                { 
                    Test_3 test_3 = new Test_3();  
                    test_3.Task_3();    
                    break;
                }
                case 4: 
                { 
                    Test_4 test_4 = new Test_4();   
                    test_4.Task_4();
                    break; 
                }
             default:
                break;
        }
        
    }
}








 



