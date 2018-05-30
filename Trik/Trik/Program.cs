using System;
using System.Linq;

namespace Trik
{
    class Program
    {
        static void Main(string[] args)
        {
            bool incorrect = false;
            bool ctn = false;
            int sum = 0;
            int ballPosition = 1;
            string moves = "";

            while (ctn == false)
            {
                incorrect = false;
                sum = 0;
                string input = Console.ReadLine();

                if (input.Length <= 50)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        char suspect = input.ElementAt(i);
                        if (suspect.Equals('A') || suspect.Equals('B') || suspect.Equals('C'))
                        {
                            sum++;
                            if (sum == input.Length && incorrect == false)
                            {
                                ctn = true;
                            }
                        }
                        else
                        {
                            incorrect = true;
                        }
                    }
                }

                moves = input;
            }

            for (int i = 0; i < moves.Length; i++)
            {
                
                char nextMove = moves.ElementAt(i);

                switch (nextMove)
                {
                    case 'A':
                    {
                       if (ballPosition == 1)
                       {
                           ballPosition = 2;
                       }
                       else if (ballPosition == 2)
                       {
                           ballPosition = 1;
                       }
                        break;
                    }
                    case 'B':
                    {
                        if (ballPosition == 2)
                        {
                            ballPosition = 3;
                        }
                        else if (ballPosition == 3)
                        {
                            ballPosition = 2;
                        }
                        break;
                    }

                    case 'C':
                    {
                        if (ballPosition == 1)
                        {
                            ballPosition = 3;
                        }
                        else if (ballPosition == 3)
                        {
                            ballPosition = 1;
                        }
                        break;
                    }
                }
            }

            Console.WriteLine(ballPosition);
        }
    }
}
