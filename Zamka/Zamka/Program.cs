using System;

namespace Zamka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[3];
            int min = 0;
            int max = 0;
            int target = 0;
            int minX = 0;
            int maxX = 0;

            bool cnt = true;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    input[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch { }

            if (input[0] > 10000 || input[0] < 1 || input[1] > 10000 || input[1] < 1 || input[1] < input[0] || input[2] > 36 || input[0] < 1)
            {
                cnt = false;
            }

            if (cnt)
            {
                min = input[0];
                max = input[1];
                target = input[2];

                for (int i = min; i <= max; i++)
                {
                    if (i < 10)
                    {
                        if (i == target)
                        {
                            minX = i;
                            break;
                        }
                    }
                    else if (i < 100)
                    {
                        int x1 = Convert.ToInt32(i.ToString().Substring(0, 1));
                        int x2 = Convert.ToInt32(i.ToString().Substring(1, 1));
                        if (x1 + x2 == target)
                        {
                            minX = i;
                            break;
                        }
                    }
                    else if (i < 1000)
                    {
                        int x1 = Convert.ToInt32(i.ToString().Substring(0, 1));
                        int x2 = Convert.ToInt32(i.ToString().Substring(1, 1));
                        int x3 = Convert.ToInt32(i.ToString().Substring(2, 1));
                        if (x1 + x2 + x3 == target)
                        {
                            minX = i;
                            break;
                        }
                    }
                    else if (i < 10000)
                    {
                        int x1 = Convert.ToInt32(i.ToString().Substring(0, 1));
                        int x2 = Convert.ToInt32(i.ToString().Substring(1, 1));
                        int x3 = Convert.ToInt32(i.ToString().Substring(2, 1));
                        int x4 = Convert.ToInt32(i.ToString().Substring(3, 1));
                        if (x1 + x2 + x3 + x4 == target)
                        {
                            minX = i;
                            break;
                        }
                    }
                    else
                    {
                        int x1 = Convert.ToInt32(i.ToString().Substring(0, 1));
                        int x2 = Convert.ToInt32(i.ToString().Substring(1, 1));
                        int x3 = Convert.ToInt32(i.ToString().Substring(2, 1));
                        int x4 = Convert.ToInt32(i.ToString().Substring(3, 1));
                        int x5 = Convert.ToInt32(i.ToString().Substring(4, 1));
                        if (x1 + x2 + x3 + x4 + x5 == target)
                        {
                            minX = i;
                            break;
                        }
                    }
                }

                for (int i = max; i >= min; i--)
                {
                    if (i < 10)
                    {
                        if (i == target)
                        {
                            maxX = i;
                            break;
                        }
                    }
                    else if (i < 100)
                    {
                        int x1 = Convert.ToInt32(i.ToString().Substring(0, 1));
                        int x2 = Convert.ToInt32(i.ToString().Substring(1, 1));
                        if (x1 + x2 == target)
                        {
                            maxX = i;
                            break;
                        }
                    }
                    else if (i < 1000)
                    {
                        int x1 = Convert.ToInt32(i.ToString().Substring(0, 1));
                        int x2 = Convert.ToInt32(i.ToString().Substring(1, 1));
                        int x3 = Convert.ToInt32(i.ToString().Substring(2, 1));
                        if (x1 + x2 + x3 == target)
                        {
                            maxX = i;
                            break;
                        }
                    }
                    else if (i < 10000)
                    {
                        int x1 = Convert.ToInt32(i.ToString().Substring(0, 1));
                        int x2 = Convert.ToInt32(i.ToString().Substring(1, 1));
                        int x3 = Convert.ToInt32(i.ToString().Substring(2, 1));
                        int x4 = Convert.ToInt32(i.ToString().Substring(3, 1));
                        if (x1 + x2 + x3 + x4 == target)
                        {
                            maxX = i;
                            break;
                        }
                    }
                    else
                    {
                        int x1 = Convert.ToInt32(i.ToString().Substring(0, 1));
                        int x2 = Convert.ToInt32(i.ToString().Substring(1, 1));
                        int x3 = Convert.ToInt32(i.ToString().Substring(2, 1));
                        int x4 = Convert.ToInt32(i.ToString().Substring(3, 1));
                        int x5 = Convert.ToInt32(i.ToString().Substring(4, 1));
                        if (x1 + x2 + x3 + x4 + x5 == target)
                        {
                            maxX = i;
                            break;
                        }
                    }
                }

                Console.WriteLine(minX);
                Console.WriteLine(maxX);
            }
        }
    }
}
