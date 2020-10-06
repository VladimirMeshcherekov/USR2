
using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if ((a == b) & (a != b))
            { // строки сравниваюся по их длинне (в теории)
                Console.WriteLine("Невозможно ");
            }

            if ((a == b) | (a != b))
            { // строки сравниваюся по их длинне
                Console.WriteLine("ну, либо они равны, либо нет ");
            }

            if (a > b)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }







        }
    }
}