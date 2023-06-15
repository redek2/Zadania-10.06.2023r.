using System;
using System.Diagnostics;

public class Program
{
    public static double Silnia(double x)
    {
        if (x == 0)
            return 1;
        else
            return x * Silnia(x - 1);
    }

    public static void Main(string[] args)
    {
        double x,n,g;
        n = 1;
        g = 0;
        Console.WriteLine("Sprawdź czy wprowadzona liczba x jest silnią jakiejś liczby n\n");
        Console.WriteLine("Podaj x:");
        x = double.Parse(Console.ReadLine());

        while(Silnia(n)<=x)
        {
            if (Silnia(n) == x)
            {
                Console.WriteLine("\nLiczba {0} jest silnią liczby {1}", x, n);
                g = 1;
                break;
            }
            n++;
        }
        if (g != 1)
            Console.WriteLine("\nLiczba {0} nie jest silnią żadnej liczby", x);
    }
}
