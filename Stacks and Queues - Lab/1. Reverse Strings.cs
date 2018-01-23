using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop().ToString());

                
            }
           
        }
    }
}
