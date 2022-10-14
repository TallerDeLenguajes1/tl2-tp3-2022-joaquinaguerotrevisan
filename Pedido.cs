using System;
namespace TP3;

public class Pedido
{
    // ATRIBUTO/S
    public int Id;
    public string Observaciones;
    public Cliente Cliente;
    public float Precio;
    public bool Estado;
    /*
        Estado = 0 : No entregado.
        Estado = 1 : Entregado;
    */

    // CONSTRUCTOR ---
    public Pedido(int _Id, string _Observaciones, float _Precio, bool _Estado, int _Id_C, string _Nombre_C, string _Domicilio_C, string _Telefono_C, string _Datos_Referencia_Direccion_C)
    {
        Id = _Id;
        Observaciones = _Observaciones;
        Cliente = new Cliente(_Id_C, _Nombre_C, _Domicilio_C, _Telefono_C, _Datos_Referencia_Direccion_C);
        Precio = _Precio;
        Estado = _Estado;
    }
}