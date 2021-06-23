using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x * x) + 14 - 3);
        }
    }
}
