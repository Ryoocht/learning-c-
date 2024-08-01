namespace FullCourseWithMiniProject;

class Program
{
    static void Main(string[] args)
    {
        const int vat = 20;
        const double percentVAT = vat / 100D;

        int balance = 1000;

        Console.WriteLine(balance * percentVAT);

        Console.ReadLine();
    }
}