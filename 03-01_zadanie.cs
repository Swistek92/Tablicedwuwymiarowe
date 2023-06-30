using System;

class Program
{
    static void Main()
    {
        

        int rows = PobierzWartosc();
        int columns = rows;
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

    static int PobierzWartosc()
    {
        Console.WriteLine("Podaj ilosc wierszy i koumn wieksza od 0 i mniejsza od 100:");

        int wartosc = int.Parse(Console.ReadLine());

        if (wartosc > 0 || wartosc <= 100)
        {
            return wartosc;
        }
        else
        {
            Console.WriteLine("podaj prawidlowa wartosc");
            return PobierzWartosc();
            
        }


    }
}