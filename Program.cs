using System;

namespace InmarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Part1 - 1
        /// </summary>
        static void CheckDivision()
        {
            for (int number = 1; number <= 100; number++)
            {
                string result = string.Empty;
                if (number / 3 == 0 && number % 5 == 0)
                {
                    result = "fizbuzz";
                }
                else if (number % 3 == 0)
                {
                    result = "fizz";
                }
                else if (number % 5 == 0)
                {
                    result = "buzz";
                }

                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Part 1 -2
        /// </summary>
        static void ReverseString()
        {
            Console.WriteLine("Enter string to be reversed");
            string input = Console.ReadLine();
            string result = string.Empty;
            for(int index=input.Length-1; index>=0;index--)
            {
                result += input[index];
            }

            Console.WriteLine(string.Format("Revesred String is:{0}", result));
        }
    }
}
