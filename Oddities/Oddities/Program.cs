using System;

namespace Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int X = 0;
            bool isNumeric = false;
            string input;

            input = Console.ReadLine();
            isNumeric = int.TryParse(input, out n);

            if (isNumeric)
            {
                for (int i = 0; i < n; i++)
                {
                    input = Console.ReadLine();
                    isNumeric = int.TryParse(input, out X);
                    if (isNumeric)
                    {
                        if (X % 2 == 0)
                        {
                            Console.WriteLine(X + " is even");
                        }
                        else
                        {
                            Console.WriteLine(X + " is odd");
                        }
                    }
                }
            }
        }
    }
}
