using System;

namespace Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cnt = false;
            bool isDigit = false;
            bool notInRange = false;
            int temp;
            string[] board = {"1", "1", "2", "2", "2", "8"};
            string newBoard="";

            while (cnt == false)
            {
                notInRange = false;
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');

                if (inputArray.Length == 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        isDigit = int.TryParse(inputArray[0], out temp);
                    }

                    if (isDigit)
                    {
                        foreach (var v in inputArray)
                        {
                            int cv = Convert.ToInt32(v);
                            if(cv < 0 || cv > 10)
                            {
                                notInRange = true;
                            }
                        }

                        if(notInRange == false)
                        for (int i = 0; i < 6; i++)
                        {
                            int piece1 = Convert.ToInt32(inputArray[i]);
                            int piece2 = Convert.ToInt32(board[i]);
                            int newPice = piece2 - piece1;
                            newBoard += newPice.ToString() + " ";
                            cnt = true;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Not a correct input");
                    }
                }
            }
            newBoard.Trim();
            Console.WriteLine(newBoard);
            
        }
    }
}
