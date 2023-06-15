public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, x;
        double e;
        e = 0;
        long Silnia(int n)
        {
            return n == 0 ? 1 : n * Silnia(n - 1);
        }

        Console.WriteLine("Suma n pierwszych wyrazów funkcji e^x\n");
        Console.WriteLine("Podaj n: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj x: ");
        x = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            e += Math.Pow(x, i) / Silnia(i);
        }
        Console.WriteLine("Suma {0} pierwszych wyrazów funkcji e^x wynosi: {1}", n, e);
    }
}