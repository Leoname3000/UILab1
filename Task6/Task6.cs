using System;
using System.Collections.Generic;

namespace Task6
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int getInput(string message)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"{message}: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        return input;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input should be integer! Try again.\n");
                    }
                }
            }

            int[] dividers = { 3, 5, 9 };
            int lowerBound = getInput("Enter lower bound");
            int upperBound = getInput("Enter upper bound");

            if (lowerBound > upperBound)
            {
                (lowerBound, upperBound) = (upperBound, lowerBound);
                Console.WriteLine("Bounds changed places");
            }
            Console.WriteLine();

            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
            foreach (var d in dividers)
            {
                result.Add(d, new List<int>());
            }
            for (int i = lowerBound; i <= upperBound; i++)
            {
                foreach (var d in dividers)
                {
                    if (i % d == 0)
                    {
                        result[d].Add(i);
                    }
                }
            }
            foreach (var d in dividers)
            {
                Console.Write($"Dividable by {d}:");
                foreach (var r in result[d])
                {
                    Console.Write($" {r}");
                }
                Console.WriteLine($" - Total of {result[d].Count}");
            }
        }
    }
}
