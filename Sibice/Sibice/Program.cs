using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Sibice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sticks = new List<int>();
            int N = 0;
            int W = 0;
            int H = 0;
            int stick = 0;
            int counter = 0;
            double D = 0;
            bool cnt = false;

            while (cnt == false)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');

                if (inputArray.Length == 3)
                {
                    bool isDigitN = int.TryParse(inputArray[0], out N);
                    bool isDigitW = int.TryParse(inputArray[1], out W);
                    bool isDigitH = int.TryParse(inputArray[2], out H);

                    if (isDigitH && isDigitN && isDigitW)
                    {
                        if (N >= 1 && N <= 50 && W >= 1 && W <= 100 && H >= 1 && H <= 100)
                        {
                            cnt = true;
                        }
                    }
                }
            }
            cnt = false;

            while (cnt == false)
            {
                string input = Console.ReadLine();

                if (input.Length > 0)
                {
                    bool isDigit = int.TryParse(input, out stick);

                    if (isDigit)
                    {
                        if (stick >= 1 && stick <= 10000)
                        {
                            sticks.Add(stick);
                            counter++;
                        }
                    }
                }
                if (counter == N)
                {
                    cnt = true;
                }
            }

            D = Math.Sqrt((H * H) + (W * W));

            foreach (var v in sticks)
            {
                if (Convert.ToDouble(v) <= D)
                {
                    Console.WriteLine("DA");
                }
                else
                {
                    Console.WriteLine("NE");
                }
            }
        }
    }
}
