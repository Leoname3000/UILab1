using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_EXPERIMENTS = 100;
            Random random = new Random();
            int heads = 0, tails = 0;
            for (int i = 0; i < NUMBER_OF_EXPERIMENTS; i++)
            {
                try
                {
                    int result = random.Next(0, 2);
                    if (result == 0) heads += 1;
                    else if (result == 1) tails += 1;
                    else throw new Exception($"Unexpected result \"{result}\"! Check random generation boundaries.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            Console.WriteLine($"Heads fell {heads} times");
            Console.WriteLine($"Tails fell {tails} times");
        }
    }
}
