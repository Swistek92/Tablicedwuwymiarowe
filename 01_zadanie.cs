using System;

class Program
{
    static void Main()
    {
        int rows = 10;
        int columns = 10;
        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = (i * columns) + j + 1;
                }
            }
            else
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = (i * columns) + columns - j;
                }
            }
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}