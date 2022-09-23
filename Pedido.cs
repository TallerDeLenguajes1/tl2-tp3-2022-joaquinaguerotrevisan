using System;
namespace TP3;

public class Pedido
{
    // ATRIBUTO/S
    public int Id;
    public string Observaciones;
    public Cliente Cliente;
    public bool Estado;
    /*
        Estado = 0 : No entregado.
        Estado = 1 : Entregado;
    */

    // CONSTRUCTOR ---
    public Pedido(int _Id, string _Observaciones, Cliente _Cliente, bool _Estado)
    {
        Id = _Id;
        Observaciones = _Observaciones;
        Cliente = _Cliente;
        Estado = _Estado;
    }
}