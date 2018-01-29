using System;
using System.Linq;
using System.Collections.Generic;

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

           
            int sum = array.Cast<int>().Sum();

            Console.WriteLine(countOfRows);
            Console.WriteLine(countOfColumns);
            Console.WriteLine(sum);


        }
    }


