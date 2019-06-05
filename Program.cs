using System;
using System.Collections.Generic;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of data of all cases.
            var dataList = new List<Tuple<int, int>>(); 

            // Fill data by manually typing on a console
            // Or comment this line and hardcode the dataList values.
            FillDataByConsole(dataList);

            // Print the result:
            Console.WriteLine("\nResult:");

            // For each data case
            foreach (var data in dataList)
                // Calculate and print the final direction.
                PrintFinalDirection(data.Item1, data.Item2);
        }

        static void FillDataByConsole(List<Tuple<int,int>> dataList)
        {
            // Enter the number of cases.
            Console.WriteLine("Enter the number of test cases (1 <= T <= 5000):");
            int cases = Int32.Parse(Console.ReadLine());

            // Validate.
            while (cases < 1 || cases > 5000)
            {
                Console.WriteLine("Please follow this conditions (1 <= T <= 5000):");
                cases = Int32.Parse(Console.ReadLine());
            }

            // For every case
            for (var i = 1; i <= cases; i++)
            {
                Console.WriteLine("\nTest case " + i);

                // Enter the number of rows.
                Console.WriteLine("Enter the number of rows (1 <= rows <= 10^9):");
                int rows = Int32.Parse(Console.ReadLine());

                // Validate.
                while (rows < 1 || rows > Math.Pow(10, 9))
                {
                    Console.WriteLine("Please follow this conditions (1 <= rows <= 10^9):");
                    rows = Int32.Parse(Console.ReadLine());
                }

                // Enter the number of columns.
                Console.WriteLine("Enter the number of columns (1 <= columns <= 10^9):");
                int columns = Int32.Parse(Console.ReadLine());

                // Validate.
                while (columns < 1 || columns > Math.Pow(10, 9))
                {
                    Console.WriteLine("Please follow this conditions (1 <= columns <= 10^9):");
                    columns = Int32.Parse(Console.ReadLine());
                }

                // Add to the data list
                dataList.Add(new Tuple<int, int>(rows, columns));
            }
        }

        /// <summary>
        /// Calculates and prints the direction in which you will be facing
        /// based on a given grid.
        /// </summary>
        /// <param name="rows">Number of raws</param>
        /// <param name="columns">Number of columns</param>
        static void PrintFinalDirection(int rows, int columns)
        {
            // If there are less or the same rows than columns
            if (rows <= columns)
            {
                // The final direction will depend on whether the rows are even or odd.
                Console.WriteLine(rows % 2 == 0 ? "L" : "R");
            }

            else // Else (there are more rows than columns)
            {
                // The final direction will depend on whether the columns are even or odd.
                Console.WriteLine(columns % 2 == 0 ? "U" : "D");
            }
        }
    }
}
