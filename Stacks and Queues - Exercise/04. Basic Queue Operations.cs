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

            var n = elements[0]; 
            var s = elements[1]; 
            var x = elements[2]; 

            var elementsToAdd = Console.ReadLine()
                .Split(charArray, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(elementsToAdd[i]);
            }

            for (int i = 0; i < s; i++)
            {
            queue.Dequeue();
            }


            if (queue.Any(y => y == x))
            {
                Console.WriteLine("true");
            }
            else if(queue.Count>0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

        }
       

    }
