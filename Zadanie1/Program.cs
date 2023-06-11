using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        c = 1;

        Console.WriteLine("Podaj naturalną podstawę potęgi:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("\nPodaj naturalny wykładnik potęgi");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        for (int i = 1; i <= b; i++)
        {
            c *= a;
        }

        Console.WriteLine("Wynik " + a + " do potęgi " + b + " jest równy " + c);
    }
}