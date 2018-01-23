using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputDecimal = int.Parse(Console.ReadLine());
            if (inputDecimal != 0)
            {


                var stack = new Stack<int>();


                while (inputDecimal > 0)
                {
                    stack.Push(inputDecimal % 2);
                    inputDecimal /= 2;
                }

                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop());
                }
            }

            else
            {
                Console.WriteLine(0);
            }
        }




    }
}

