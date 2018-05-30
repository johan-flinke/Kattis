using System;

namespace QuadrantSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ctn = false;
            bool isNumeric = false;
            int X = 10;
            int Y = 10;



            while (ctn == false)
            {
                string input = Console.ReadLine();

                //input = null;
                try
                {
                    string[] inputArray = input.Split(' ');

                    isNumeric = int.TryParse(inputArray[0], out X);

                    if (isNumeric)
                    {
                        if ((X >= -1000 && X <= 1000 && X != 0))
                        {
                            ctn = true;
                        }
                    }
                }
                catch { }

            }
            ctn = false;
            while (ctn == false)
            {
                string input = Console.ReadLine();

                try
                {
                    string[] inputArray = input.Split(' ');

                    isNumeric = int.TryParse(inputArray[0], out Y);

                    if (isNumeric)
                    {
                        if ((Y >= -1000 && Y <= 1000 && Y != 0))
                        {
                            ctn = true;
                        }
                    }
                }
                catch { }

            }

            string answer = "";

            if (X > 0 && Y > 0)
            {
                answer = "1";
            }
            else if (X < 0 && Y > 0)
            {
                answer = "2";
            }
            else if (X < 0 && Y < 0)
            {
                answer = "3";
            }
            else
            {
                answer = "4";
            }

            Console.WriteLine(answer);
        }
    }
}
