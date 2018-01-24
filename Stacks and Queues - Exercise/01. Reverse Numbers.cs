using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var charArray = " "
                .ToArray();

            var numbersInput = Console.ReadLine()
                .Split(charArray,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>();

            foreach (var number in numbersInput)
            {
                stack.Push(number);
            }

            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop().ToString()} ");

            }




        }
    }

