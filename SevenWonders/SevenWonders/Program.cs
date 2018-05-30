using System;
using System.Linq;

namespace SevenWonders
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cnt = true;
            string input = "";
            int T = 0;
            int G = 0;
            int C = 0;

            int total = 0;
            try
            {
                input = Console.ReadLine();
                input = input.ToUpper();
            }

            catch { }

            for (int i = 0; i < input.Length; i++)
            {
                if((input.Substring(i,1).Contains('T')))
                {
                    T++;
                }
                else if ((input.Substring(i, 1).Contains('C')))
                {
                    C++;
                }
                else if ((input.Substring(i, 1).Contains('G')))
                {
                    G++;
                }

                else
                {
                    cnt = false;
                    Console.WriteLine("Wrong input");
                    break;
                }
            }

            if (cnt)
            {
                total = (C * C) + (G * G) + (T * T);
                if (C > 0 && G > 0 && T > 0)
                {
                    int min = C;

                    if (G < min)
                    {
                        min = G;
                    }

                    if (T < min)
                    {
                        min = T;
                    }
                    total += 7*min;
                }
                Console.WriteLine(total);
            }
        }
    }
}
