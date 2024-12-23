using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        //•	Задача 7: Напишите программу, которая выводит числа от N до 1 в обратном порядке.
        public static string number;
        public static int result;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число больше 1");
            number = Console.ReadLine();
            result = int.Parse(number);
            for(int i = result; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.Write(i);
                    return;
                }
                Console.Write(i + ", ");
                
            }
        }
    }
}
