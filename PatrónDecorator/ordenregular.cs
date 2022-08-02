using System;
namespace PatronDecorator;
public class ordenregular : OrdenBase
{
    public override double CalculoTotal()
    {
        Console.WriteLine("Calculo del precio total de un pedido normal");
        return productos.Sum(x => x.precio);
    }
}
