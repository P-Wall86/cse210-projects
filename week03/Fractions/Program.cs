using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal: {fraction1.GetDecimalValue()}");
        Console.WriteLine();

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction: {fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal: {fraction2.GetDecimalValue()}"); 
        Console.WriteLine();

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal: {fraction3.GetDecimalValue()}"); 
        Console.WriteLine();

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction: {fraction4.GetFractionString()}");
        Console.WriteLine($"Decimal: {fraction4.GetDecimalValue()}");
    }
}
