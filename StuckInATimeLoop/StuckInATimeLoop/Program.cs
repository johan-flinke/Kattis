using System;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            while (N < 1 || N > 101)
            {
                N = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("{0} {1}",i,"Abracadabra");
            }
        }
    }
}
