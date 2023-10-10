using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_DIVIDER = 2;
            const int MAX_DIVIDER = 10;
            int num;
            while(true)
            {
                try
                {
                    Console.Write("Enter number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input should be integer! Try again.\n");
                }
            }
            List<int> dividers = new List<int>();
            for (int i = MIN_DIVIDER; i <= MAX_DIVIDER; i++)
            {
                if (num % i == 0)
                {
                    dividers.Add(i);
                }
            }
            if (dividers.Count == 0)
            {
                Console.WriteLine($"No dividers found!");
            } 
            else
            {
                Console.Write($"Dividers from {MIN_DIVIDER} to {MAX_DIVIDER}:");
                foreach (var d in dividers)
                {
                    Console.Write($" {d}");
                }
                Console.WriteLine();
            }
        }
    }
}
