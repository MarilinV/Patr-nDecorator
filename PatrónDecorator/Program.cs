using System;
namespace PatronDecorator;
public class Program
{
    private static void Main(string[] args)
    {
        var OrdenRegular = new ordenregular();
        Console.WriteLine(OrdenRegular.CalculoTotal());
        Console.WriteLine();

        var Preorden = new preorden();
        Console.WriteLine(Preorden.CalculoTotal());
        Console.WriteLine();

        var OrdenPremium = new ordenpremium(Preorden);
        Console.WriteLine(OrdenPremium.CalculoTotal());
        Console.WriteLine();
    }
}
