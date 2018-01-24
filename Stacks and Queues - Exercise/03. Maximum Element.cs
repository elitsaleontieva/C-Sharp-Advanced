using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var commandsCount = int.Parse(Console.ReadLine());

        var stack = new Stack<int>();
        var maxStack = new Stack<int>();

        maxStack.Push(int.MinValue);

        for (int i = 0; i < commandsCount; i++)
        {
            var command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();



            switch (command[0])
            {
                case 1:
                    var element = command[1];
                    stack.Push(element);
                    if (element>=maxStack.Peek())
                    {
                        maxStack.Push(element);
                    }
                    break;

                case 2:
                    var elementRemoved = stack.Pop();
                    if (maxStack.Peek()==elementRemoved)
                    {
                        maxStack.Pop();
                    }
                    break;

                case 3:
                    Console.WriteLine(maxStack.Peek());
                    break;
            }
        }


        }
       

    }
