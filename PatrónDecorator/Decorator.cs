using System;
namespace PatronDecorator;
public class Decorator : OrdenBase
{
    protected OrdenBase orden;
    public Decorator(OrdenBase orden)
    {
        this.orden = orden;
    }
    public override double CalculoTotal()
    {
        Console.WriteLine("Calculo del precio total desde la clase decoradora");
        return orden.CalculoTotal();
    }
}
