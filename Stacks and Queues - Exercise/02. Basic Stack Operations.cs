using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
            var charArray = " "
                .ToArray();

            var elements = Console.ReadLine()
                .Split(charArray, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var n = elements[0]; //number of elements to push onto the stack
            var s = elements[1]; //number of elements to pop from the stack 
            var x = elements[2]; //an element that you should look for in the stack

            var elementsToPushOntoStack = Console.ReadLine()
                .Split(charArray, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(elementsToPushOntoStack[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }


            if (stack.Any(y => y == x))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count>0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

        }
       

    }
