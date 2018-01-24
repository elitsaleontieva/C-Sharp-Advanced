using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var queue = new Queue<int[]>();

        for (int i = 0; i < n; i++)
        {
            var pump = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            queue.Enqueue(pump);
        }

        for (int currentStart = 0; currentStart < queue.Count - 1; currentStart++)
        {
            int fuel = 0;
            bool isSolution = true;


            for (int pumpsPassed = 0; pumpsPassed < queue.Count - 1; pumpsPassed++)
            {

                var currentPump = queue.Dequeue();

                int pumpFuel = currentPump[0];
                int nextPumpDistance = currentPump[1];

                queue.Enqueue(currentPump);

                fuel += pumpFuel - nextPumpDistance;
                if (fuel<0)
                {
                    currentStart += pumpsPassed;
                    isSolution = false;
                    break;
                }
            }

            if (isSolution)
            {
                Console.WriteLine(currentStart);
                Environment.Exit(0);
            }
        }


    }


}

