using System;
using System.Text.RegularExpressions;

namespace Apaxiaaans
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            try
            {
                
                if (Regex.IsMatch(input, @"^[a-z]+$"))
                {
                    input = input.Trim();
                    if (input.Length > 1 && input.Length <= 250)
                    {
                        input = input.Replace(" ", "");

                        var suspect = input.Substring(0, 1);
                        for (int i = 0; i < input.Length - 1; i++)
                        {
                            suspect = input.Substring(i, 1);
                            if (!input.Substring(i + 1, 1).Equals(suspect))
                            {
                                output += suspect;
                            }
                        }
                        if (!input.Substring(input.Length - 1, 1).Equals(input.Substring(input.Length - 2)))
                        {
                            output += input.Substring(input.Length - 1, 1);
                        }
                    }
                    else
                    {
                        output = input;
                    }

                    Console.WriteLine(output);
                }
                
            }
            catch { }
        }
    }
}
