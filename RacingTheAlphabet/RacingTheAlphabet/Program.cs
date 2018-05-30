using System;
using System.Collections.Generic;
using System.Linq;

namespace RacingTheAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray =
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z', ' ', '\''
            };

            int antalPunkter = 28;
            double diameter = 60.0;
            double radius = diameter / 2.0;
            double antalGraderMellanPunkter = 360.0 / antalPunkter;
            double arcLength = (Math.PI/180) * radius * antalGraderMellanPunkter;
            string aphorism = "a";
            int currentPosition = Convert.ToInt32(aphorism.ElementAt(0) - 65); ;
            int nextPosition = 0;
            int numberOfSteps = 0;
            int positionDistance = 0;
            int antalAphorismer = 0;
            List<string> aphorismer = new List<string>();
            bool cnt = false;

            while (cnt == false)
            {
                string input = Console.ReadLine();
                bool isDigit = int.TryParse(input, out antalAphorismer);

                if (isDigit)
                {
                    if (antalAphorismer >= 1 && antalAphorismer <= 20)
                    {
                        cnt = true;
                    }
                }
            }

            cnt = false;
            bool charCheck = false;
            bool addCheck = false;
            bool errorCheck = false;

            while (cnt == false)
            {
                for (int i = 0; i < antalAphorismer; i++)
                {
                    addCheck = false;
                    while (addCheck == false)
                    {
                        string newInput = Console.ReadLine().ToUpper();
                        errorCheck = false;
                        if (newInput.Length > 7 && newInput.Length < 121)
                        {
                            for (int j = 0; j < newInput.Length; j++)
                            {
                                charCheck = false;
                                char suspect = newInput.ElementAt(j);
                                for (int k = 0; k < charArray.Length; k++)
                                {
                                    if (suspect.Equals(charArray[k]))
                                    {
                                        charCheck = true;
                                    }
                                }

                                if (!charCheck)
                                {
                                    errorCheck = true;
                                    break;
                                }
                            }

                            if (errorCheck == false)
                            {
                                aphorismer.Add(newInput);
                                addCheck = true;
                                if (aphorismer.Count == antalAphorismer)
                                {
                                    cnt = true;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < aphorismer.Count; i++)
            {
                numberOfSteps = 0;
                positionDistance = 0;
                nextPosition = 0;

                aphorism = aphorismer[i];
                currentPosition = Convert.ToInt32(aphorism.ElementAt(0) - 65); ;

                for (int j = 1; j < aphorism.Length; j++)
                {
                    nextPosition = Convert.ToInt32(aphorism.ElementAt(j) - 65);
                    if (nextPosition == -33)
                    {
                        nextPosition = 26;
                    }
                    if (nextPosition == -26)
                    {
                        nextPosition = 27;
                    }
                    positionDistance = Math.Abs(currentPosition - nextPosition);
                    if (positionDistance > 14)
                    {
                        positionDistance = 28 - positionDistance;
                    }
                    numberOfSteps += positionDistance;
                    currentPosition = nextPosition;
                }

                int numberOfLetters = aphorism.Length;
                double distance = numberOfSteps * arcLength;

                Console.WriteLine("{0}", (distance / 15) + numberOfLetters);
            }
        }
    }
}
