using System;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int X=255;
            while (X < 1 || X > 100)
            {
                X = Convert.ToInt32(Console.ReadLine());
            }
             
            int N=255;

            while (N < 1 || N > 100)
            {
                N = Convert.ToInt32(Console.ReadLine());
            }

            int max = N * X;

            int spent = 0;
            int total = 0;
            bool ok = false;

            for (int i = 0; i < N; i++)
                
            {
                while (ok==false)
                {
                    spent = Convert.ToInt32(Console.ReadLine());
                    if (spent > max)
                    {
                        ok = false;
                    }
                    else if (spent + total > max)
                    {
                        ok = false;
                    }

                    else
                    {
                        total += spent;
                        break;
                    }
                }
            }
            Console.WriteLine((N+1) * X-total);
        }
    }
}
