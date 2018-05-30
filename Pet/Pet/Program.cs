using System;
using System.Collections.Generic;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cnt = false;
            int X;
            int bestScore;
            int winner = 0;
            bool isNumber = false;
            List<int> ScoreBoard = new List<int>();

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    int total = 0;
                    int count = 0;
                    string input = Console.ReadLine();
                    string[] scores = input.Split(' ');

                    foreach (var s in scores)
                    {
                        cnt = false;
                        isNumber = int.TryParse(s, out X);

                        if (isNumber && X < 6 && X > 0)
                        {
                            count++;
                            total += X;
                        }

                        if (count == 4)
                        {
                            ScoreBoard.Add(total);
                            cnt = true;
                        }
                    }
                }

                if (cnt)
                {
                    bestScore = ScoreBoard[0];
                    foreach (var s in ScoreBoard)
                    {
                        if (s > bestScore)
                        {
                            bestScore = s;
                        }
                    }

                    for (int i = 0; i < 5; i++)
                    {

                        if (ScoreBoard[i] == bestScore)
                        {
                            winner = i + 1;
                        }
                    }

                    Console.WriteLine(winner + " " + bestScore);
                }
            }
            catch { }
        }
    }
}
