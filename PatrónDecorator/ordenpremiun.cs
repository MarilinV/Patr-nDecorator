using System;
namespace PatronDecorator;
public class ordenpremium : Decorator
{
    public ordenpremium(OrdenBase orden) : base(orden)
    {

    }

    public override double CalculoTotal()
    {
        Console.WriteLine("Calculo Total Precio Orden Premium");
        var precioordenprecio = base.CalculoTotal();
        return precioordenprecio * 0.9;
    }
}
