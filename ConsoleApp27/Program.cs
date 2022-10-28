using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int Xf = 0; 
            Console.WriteLine("Введите число, которое необходимо исследовать.\n");
            Xf = Console.Read();
            int Xi_2 = 0, Xi_1 = 1; 
            int Xi = 0;
            while (true)
            {
                Xi = Xi_1 + Xi_2; 
                Xi_2 = Xi_1;       
                Xi_1 = Xi;        
                if ((Xf == Xi) || (Xf == 0))
                {
                    Console.WriteLine("Введенное число принадлежит последовательности Фибоначчи\n");
                    break;
                }
                else if (Xf < Xi)
                {
                    Console.WriteLine("Введенное число не принадлежит последовательности Фибоначчи\n");
                    break;
                }
            }
        }
    }
}