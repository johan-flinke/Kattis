using System;
using System.Linq;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = 0;
            int N=0;
            int P;
            bool cnt = false;

            while (N <= 0 || N >= 11)
            {
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out N);
            }

            for (int i = 0; i < N; i++)
            {
                cnt = false;
                while (cnt == false)
                {
                    string input = Console.ReadLine();

                    if (input.Length > 1 && input.Length < 5)
                    {
                        if (input.All(char.IsDigit))
                        {
                            P = Convert.ToInt32(input.Substring(input.Length - 1));
                            X += Math.Pow(Convert.ToInt32(input.Substring(0, input.Length - 1)), P);
                            cnt = true;
                        }

                        else
                        {
                            Console.WriteLine("Not digit");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Must be between 10 and 9999");
                    }
                }
            }

            if (X > 1000000000)
            {
                X = 1000000000;
            }
            Console.WriteLine(X);
        }
    }
}
