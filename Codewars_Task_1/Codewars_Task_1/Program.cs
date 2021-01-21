using System;

namespace Codewars_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var JadenCase = new JadenCase();
            Console.WriteLine("Enter any text, and every first letter of every word in sentence will be capitalized:");
            Console.WriteLine(JadenCase.ToJadenCase(Console.ReadLine()) + "\n");
            Console.ReadLine();
        }
    }
}
