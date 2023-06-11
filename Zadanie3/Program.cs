public class MyProgram
{
    public static double Silnia(double n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Silnia(n - 1);
        }
    }

    public static void Main(string[] args)
    {
        double m, n, k, a, b;

        Console.WriteLine("Program wylicza równanie m=(n!-k!)/k!, dla naturalnych n, k >= 5");
        Console.WriteLine("Podaj n:");
        n = double.Parse(Console.ReadLine());

        while (n < 5)
        {
            Console.WriteLine("Proszę podać liczbę większą lub równą 5");
            n = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Podaj k:");
        k = double.Parse(Console.ReadLine());

        while (k < 5)
        {
            Console.WriteLine("Proszę podać liczbę większą lub równą 5");
            k = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nm=(" + n + "!-" + k + "!)/" + k + "!");
        a = Silnia(n);
        b = Silnia(k);
        Console.WriteLine("\nm=("+a+"-"+b+")/"+b);
        m = (a - b) / b;
        Console.WriteLine("\nm=" + m);
    }
}