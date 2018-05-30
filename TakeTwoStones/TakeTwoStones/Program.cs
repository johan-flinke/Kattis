using System;

namespace TakeTwoStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            while (N < 1 || N > 10000001)
            {
                N = Convert.ToInt32(Console.ReadLine());
            }

            if (N % 2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
            
        }
    }
}
