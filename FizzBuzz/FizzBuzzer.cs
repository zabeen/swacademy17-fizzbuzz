using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
		public int MessageCount
		{
			get { return MessageList.Count; }
		}

        public string CompleteMessage
        {
            get { return string.Join("", MessageList); }
        }

        public string CompleteMessageInReverse
        {
            get { return JoinMessagesInReverse(); }
        }

        private Dictionary<int,string> Words;
        private List<string> MessageList;

        public FizzBuzzer()
        {
            // initialise
            MessageList = new List<string>();

            // create dict matching divisors to words
            Words = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
                { 7, "Bang" },
                { 11, "Bong" },
                { 13, "Fezz" }
            };
        }

        private int IndexOfFirstMessageToStartWith(char firstLetter)
        {
            // return index as soon as message beginning with requested first letter found
            for (int i = 0; i < MessageList.Count; i++)
            {
                if (MessageList[i].StartsWith(firstLetter))
				{
                    return i;
				}
            }

            // if no message in list begins with first letter
            return -1;
        }

        private string JoinMessagesInReverse()
        {
            // if list to be joined in reverse order
            string reversed = "";
			// start counter at last index, and decrement uptil & including first index
			for (int i = MessageList.Count - 1; i >= 0; i--)
			{
				reversed += MessageList[i];
			}

			return reversed;
        }

		public bool IsDivisibleBy(int dividend, int divisor)
		{
			if (dividend % divisor == 0)
			{
				return true;
			}

			return false;
		}

		public void AmendMessageList(string message)
		{
			MessageList.Add(message);
		}

		public void AmendMessageList(int dividend, int divisor, bool overwrite = false)
		{
			// if dividend is divisible by divisor, then retrieve word from dict
			if (IsDivisibleBy(dividend, divisor) && Words.TryGetValue(divisor, out string word))
			{
				// clear list first if overwrite option selected
				if (overwrite)
					MessageList.Clear();

				// add dict word to list
				MessageList.Add(word);
			}
		}

		public void InsertIntoMessageListByFirstLetter(int dividend, int divisor, char firstLetter)
		{
			// if dividend is divisible by divisor, then retrieve word from dict
			if (IsDivisibleBy(dividend, divisor) && Words.TryGetValue(divisor, out string word))
			{
				// get index of first element in message list that begins with char
				int index = IndexOfFirstMessageToStartWith(firstLetter);

				// if no message in list begins with char
				if (index == -1)
				{
					// append word to end of list
					AmendMessageList(dividend, divisor);
				}
				else
				{
					// insert word at substr index
					MessageList.Insert(index, word);

				}
			}
		}
    }
}
