using System;

namespace Codewars_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B:");
            int b = Convert.ToInt32(Console.ReadLine());
            var sumator = new Sumator();
            Console.WriteLine($"Сумма чисел:{sumator.GetSum(a, b)}");
            Console.ReadLine();
        }
    }
}
