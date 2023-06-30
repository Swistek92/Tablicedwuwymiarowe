using System;

class Program
{
    static void Main()
    {
        int Size = PobierzWartosc();
        int[,] tablica = WypelnijTablice(Size);

        WypiszTablice(tablica);
        Console.ReadKey();
    }

    static int[,] WypelnijTablice(int Size)
    {
        int[,] tablica = new int[Size, Size];
        int liczba = 1;

        for (int i = 0; i < Size; i++)
        {
            if (i % 2 == 0) // wiersze parzyste
            {
                for (int j = 0; j < Size; j++)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
            else // wiersze nieparzyste
            {
                for (int j = Size - 1; j >= 0; j--)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
        }

        return tablica;
    }

    static void WypiszTablice(int[,] tablica)
    {
        int liczbaWierszy = tablica.GetLength(0);
        int liczbaKolumn = tablica.GetLength(1);

        for (int i = 0; i < liczbaWierszy; i++)
        {
            for (int j = 0; j < liczbaKolumn; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
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