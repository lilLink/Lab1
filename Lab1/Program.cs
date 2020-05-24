using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine("New York Times", Frequency.Monthly, new DateTime(2009, 12, 31), 300);
            Console.WriteLine(magazine.ToShortString());

            Console.WriteLine($"Weekly: {magazine[Frequency.Weekly]}");
            Console.WriteLine($"Monthly: {magazine[Frequency.Monthly]}");
            Console.WriteLine($"Yearly: {magazine[Frequency.Yearly]}");

            magazine.FrequencyMagazine = Frequency.Weekly;
            magazine.EditionMagazine = 21;
            magazine.NameMagazine = "Daily Bugles";
            magazine.DatePublished = new DateTime(2012, 11, 11);
            Console.WriteLine(magazine.ToString());

            magazine.AddArticles(new Article(new Person("Mary", "Watson", new DateTime(1990, 09, 02)), "SCI-FI", 9.9));
            Console.WriteLine(magazine.ToString());

            Console.WriteLine("---------------------------");

            //-------------------Time-----------------------
            Console.Write("Delimiters: ");
            String delimiter = Console.ReadLine();
            Console.Write("Input count of rows and cols, using delimiter: ");
            String[] rowsCols = Console.ReadLine().Split(delimiter.ToCharArray());

            int rows = int.Parse(rowsCols[0]);
            int cols = int.Parse(rowsCols[1]);

            Article[] normalArray = new Article[rows * cols];
            for (int i = 0; i < normalArray.Length; i++)
            {
                normalArray[i] = new Article();
            }

            Article[,] twoDimensiomalAray = new Article[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    twoDimensiomalAray[i, j] = new Article();
                }

            Article[][] jaggedRectangularArray = new Article[rows][];
            for (int i = 0; i < rows; i++)
            {
                jaggedRectangularArray[i] = new Article[cols];
                for (int j = 0; j < cols; j++)
                {
                    jaggedRectangularArray[i][j] = new Article();
                }
            }

            int rowsCount = 0;
            int all = rows * cols;
            while (all - rowsCount > 0)
            {
                all -= rowsCount;
                rowsCount++;
            }

            Article[][] jaggedArray = new Article[rowsCount][];
            for (int i = 0; i < rowsCount; i++)
            {
                jaggedArray[i] = new Article[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    jaggedArray[i][j] = new Article();
                }
            }

            int startTime;
            int finishTime;

            startTime = Environment.TickCount;
            for (int i = 0; i < normalArray.Length; i++)
            {
                normalArray[i].Name = "Atricle 1";
            }

            finishTime = Environment.TickCount;

            Console.WriteLine($"\nNormal array \nCount of elements: {normalArray.Length} \nTime: {-startTime + finishTime}\n");

            startTime = Environment.TickCount;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    twoDimensiomalAray[i, j].Name = "Article1";
                }
            finishTime = Environment.TickCount;

            Console.WriteLine($"Twodimensional array \nCount of rows: {rows}\nCount of cols: {cols}");
            Console.WriteLine($"Time: {-startTime + finishTime}\n");

            startTime = Environment.TickCount;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    jaggedRectangularArray[i][j].Name = "Article1";
                }
            finishTime = Environment.TickCount;

            Console.WriteLine($"Jagged rectangle array \nCount of rows: {rows}\nCount of cols: {cols}");
            Console.WriteLine($"Time: {-startTime + finishTime}\n");

            startTime = Environment.TickCount;
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j <= i; j++)
                {
                    jaggedArray[i][j].Name = "Article1";
                }
            finishTime = Environment.TickCount;

            Console.Write($"Jagged array \nCount of rows: {rowsCount}\nCount of cols: ");
            foreach (Article[] arr in jaggedArray)
            {
                Console.Write($"{arr.Length} ");
            }
            Console.WriteLine($"\nTime: {-startTime + finishTime}");


            Console.ReadLine();

        }
    }
}
