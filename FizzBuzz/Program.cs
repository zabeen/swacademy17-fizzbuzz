using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 1; i < 300; i++)
            {
                FizzBuzzer fb = new FizzBuzzer();

                // i is divisible by 3, append
                fb.AmendMessageList(i, 3);

                // i is divisible by 5, append
                fb.AmendMessageList(i, 5);

                // multiple of 7, append
                fb.AmendMessageList(i, 7);

                // multiple of 11, overwrite
                fb.AmendMessageList(i, 11, true);

                // multiple of 13, insert before 'B' word
                fb.InsertIntoMessageListByFirstLetter(i, 13, 'B');

                // add value of i to message list, if no rule encountered thus far
                if (fb.MessageCount == 0)
                {
                    fb.AmendMessageList(i.ToString());
                }

                // print out Fizzbuzzer message
                Console.WriteLine((fb.IsDivisibleBy(i, 17)) ? fb.CompleteMessageInReverse : fb.CompleteMessage);
            }
        }
    }
}
