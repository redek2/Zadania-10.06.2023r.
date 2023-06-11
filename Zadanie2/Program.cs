public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, n;

        Console.WriteLine("Program wypisuje n pierwszych wyrazów ciągu Fibonacciego");
        Console.WriteLine("Podaj n:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        for(int i = 1; i <= n; i++)
        {
            a = CiagFibonacciego(i);
            Console.WriteLine("" + a);
        }
    }

    static int CiagFibonacciego(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return CiagFibonacciego(n - 1) + CiagFibonacciego(n - 2);
        }
    }
}