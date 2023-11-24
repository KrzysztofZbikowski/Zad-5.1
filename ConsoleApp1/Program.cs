class zad
{
    static double temp(double x)
    {
        return (5.0 / 9 * (x - 32));
    }
    static void Main(string[] args)
    {
        double x;
        Console.WriteLine("Podaj temperaturę w stopniach Fahrenheita: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Twoja temperaturę w stopniach Celciusza: ");
        Console.WriteLine(temp(x));
        Console.ReadKey();
    }
}