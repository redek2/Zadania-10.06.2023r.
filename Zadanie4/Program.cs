public class MyProgram
{
    public static void Main(string[] args)
    {
        double a,b,c,oprocentowanieMiesieczne,zarobione,podatek,zysk;

        Console.WriteLine("Wpisz kwotę początkową którą wpłacisz na konto oszczędnościowe:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Wpisz oprocentowanie konta w skali roku:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Wpisz liczbę miesięcy oszczędzania:");
        c = int.Parse(Console.ReadLine());

        oprocentowanieMiesieczne = b / 12 / 100;
        zarobione = a * oprocentowanieMiesieczne * c;
        podatek = zarobione * 0.19;
        zysk = zarobione - podatek;

        Console.WriteLine("\nUwzględniając podatek Belki, po odłożeniu na konto "+a+"zł na okres "+c+" miesięcy, zarobisz "+zysk+"zł");
    }
}