using System;

namespace Task7
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

            const int NUMBER_OF_INPUTS = 10;
            int sum = 0, max = int.MinValue;
            for (int i = 0; i < NUMBER_OF_INPUTS; i++)
            {
                int input = getInput($"Enter number {i+1}");
                sum += input;
                if (input > max)
                {
                    max = input;
                }
            }
            float average = (float) sum / NUMBER_OF_INPUTS;
            Console.WriteLine($"\nMax value: {max}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
