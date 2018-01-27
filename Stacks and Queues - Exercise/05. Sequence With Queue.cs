using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        var queue = new Queue<long>();
        queue.Enqueue(n);

        var calculatedNumbers = new Queue<long>();
        calculatedNumbers.Enqueue(n);

        for (long i = 0; i < 50; i++)
        {
            var firstElement = queue.Peek();

            var firstExpression = firstElement + 1;
            var secondExpression = (firstElement * 2) + 1;
            var thirdExpression = firstElement + 2;

            queue.Enqueue(firstExpression);
            queue.Enqueue(secondExpression);
            queue.Enqueue(thirdExpression);

            calculatedNumbers.Enqueue(firstExpression);
            calculatedNumbers.Enqueue(secondExpression);
            calculatedNumbers.Enqueue(thirdExpression);

            queue.Dequeue();
        }

        var results = new List<long>();

        foreach (var element in calculatedNumbers)
        {
            results.Add(element);
        }

        if (results.Count > 50)
        {
            results.RemoveRange(50, results.Count - 50);

        }

        Console.WriteLine(string.Join(" ", results));


    }
}
