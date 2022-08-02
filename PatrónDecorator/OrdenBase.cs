using System;
namespace PatronDecorator;
public abstract class OrdenBase
{
    protected List<Producto> productos = new List<Producto>
    {
        new Producto {nombre = "Telefono", precio = 800},
        new Producto {nombre = "Tablet", precio = 800},
        new Producto {nombre = "Pc Gamer", precio = 1800},
    };

    public abstract double CalculoTotal();

}