using System;
using System.Collections.Generic;

namespace BatterUp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cnt = false;
            bool isDigit = false;
            bool notInRange = false;
            int bats = 0;
            int temp = 0;
            decimal result = 0;
            List<int> nom = new List<int>();

            while (bats < 1)
            {
                string NumberOfbats = Console.ReadLine();
                isDigit = int.TryParse(NumberOfbats, out bats);
                if (bats < 1 || bats > 100)
                {
                    Console.WriteLine("Wrong input");
                    bats = 0;
                }
            }


            while (cnt == false)
            {
                notInRange = false;
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');

                
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        isDigit = int.TryParse(inputArray[i], out temp);
                        if (isDigit == false)
                        {
                            break;
                        }
                    }

                    if (isDigit)
                    {

                        if (inputArray.Length == bats)
                        {
                            foreach (var v in inputArray)
                            {
                                int cv = Convert.ToInt32(v);
                                if (cv < -1 || cv > 4)
                                {
                                    notInRange = true;
                                }

                                else if (cv != -1)
                                {
                                    nom.Add(cv);
                                }
                            }

                            if (notInRange == false && nom.Count > 0)
                            {
                                foreach (int item in nom)
                                {
                                    result += item;

                                }

                                result /= nom.Count;

                                cnt = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Numbers dont match");
                        }
                        
                    }

                    else
                    {
                        Console.WriteLine("Not a correct input");
                    }
                
            }
            
            Console.WriteLine(result);
        }
    }
}
