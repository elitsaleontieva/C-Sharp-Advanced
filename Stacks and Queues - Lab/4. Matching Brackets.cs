using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var stackOpenBracketIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                     stackOpenBracketIndex.Push(i);
                }
                if (input[i] == ')')
                {
                    var openBracketIndex = stackOpenBracketIndex.Pop();
                    var length = i - openBracketIndex + 1;
                    Console.WriteLine(input.Substring(openBracketIndex,length));
                }

            }

        }




    }
}

