using System;
using System.Linq;

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            try
            {
                input = input.ToLower();
                input = input.Trim();
            }
            catch
            {
            }

            if (input.Length < 101)
            {
                output += input.Substring(0, 1).ToUpper();
                for (int i = 1; i < input.Length-1; i++)
                {
                    if (input.Substring(i, 1).Contains('-'))
                    {
                        output += input.Substring(i+1, 1).ToUpper();
                    }
                }
                Console.WriteLine(output);
            }
        }
    }
}
