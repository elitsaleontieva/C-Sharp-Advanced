using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ');
            var limit = int.Parse(Console.ReadLine());
            var queque = new Queue<string>(input);

            while (queque.Count!=1)
            {
                for (int i = 1; i < limit; i++)
                {
                    queque.Enqueue(queque.Dequeue());
                }

                Console.WriteLine($"Removed {queque.Dequeue()}");
            }
            Console.WriteLine($"Last is {queque.Dequeue()}");



        }
    }
}
