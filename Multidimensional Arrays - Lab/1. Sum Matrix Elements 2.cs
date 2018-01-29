using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            var charArr = ",".ToCharArray();
            var input = Console.ReadLine()
                .Split(charArr,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var countOfRows = input[0];
            var countOfColumns = input[1];

            int[,] array = new int[countOfRows, countOfColumns];

            for (int rows = 0; rows < countOfRows; rows++)
            {
                var values=Console.ReadLine().Split(charArr, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int columns = 0; columns < countOfColumns; columns++)
                {
                   array[rows,columns] = values[columns];

                }
            }

            var sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
              
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine(countOfRows);
            Console.WriteLine(countOfColumns);
            Console.WriteLine(sum);

        }
    }
}
