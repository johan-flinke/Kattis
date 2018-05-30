using System;
using System.Linq;

namespace HissingMicrophone
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool hiss = false;
            try
            {
                input = input.ToLower();
                input = input.Trim();
            }
            catch
            {
            }

            if (input.Length < 31)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input.Substring(i, 1).Contains('s') && input.Substring(i + 1, 1).Contains('s'))
                    {
                        hiss = true;
                        break;
                    }
                }

                if (hiss)
                {
                    Console.WriteLine("hiss");
                }
                else
                {
                    Console.WriteLine("no hiss");
                }
            }

        }
    }
}
