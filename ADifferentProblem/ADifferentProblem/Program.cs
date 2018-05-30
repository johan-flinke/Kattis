using System;

namespace ADifferentProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            long number1 = long.Parse(split[0]);
            long number2 = long.Parse(split[1]);
            long answer = Math.Abs(number1 - number2);
            Console.WriteLine(answer);

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split2 = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                long a = Int64.Parse(split2[0]), b = Int64.Parse(split2[1]);
                Console.WriteLine(Math.Abs(a - b));
            }
        }
    }
}
