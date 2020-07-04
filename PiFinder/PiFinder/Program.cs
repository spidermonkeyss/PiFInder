//Find PI to the Nth Digit – Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.

using System;

namespace PiFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pi = FindPi();

            const int MAX_NTH = 26;
            int nthNumber = 0;

            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Enter number. Max 50");
                string input = Console.ReadLine();
                bool isNum = int.TryParse(input, out int i);
                if (!isNum)
                {
                    Console.WriteLine("Invaild input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                nthNumber = Convert.ToInt32(input);
                char digit;

                if (nthNumber > MAX_NTH)
                {
                    Console.WriteLine("Too high");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                else if (nthNumber == 0)
                {
                    Console.WriteLine("Invaild number");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                else if (nthNumber == 1)
                {
                    digit = '3';
                }
                else if (nthNumber == 2)
                {
                    digit = '1';
                }
                else
                {
                    string piString = pi.ToString();
                    digit = piString[nthNumber - 0];
                }
                //Console.WriteLine(pi);
                Console.WriteLine("Digit " + digit);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static decimal FindPi()
        {
            const int iterations = 10000000;
            bool doAdd = true;
            int denom = 1;
            decimal pi = 0;
            for (int i = 0; i < iterations; i++)
            {
                if (doAdd)
                    pi += ((decimal)4 / (decimal)denom);
                else
                    pi -= ((decimal)4 / (decimal)denom);

                doAdd = !doAdd;
                denom += 2;
            }
            return pi;
        }
    }
}
