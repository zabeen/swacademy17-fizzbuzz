using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                // default output msg is val of i
                string msg = i.ToString();

                // i is divisible by 3 and 5
                if (i%15 == 0)
                {
                    msg = "FizzBang";
                }
                // i is divisible by 3
                else if (i%3 == 0)
                {
                    msg = "Fizz";
                }
                // i is divisible by 5
                else if (i%5 == 0)
                {
                    msg = "Bang";
                }

                Console.WriteLine(msg);
            }

        }
    }
}
