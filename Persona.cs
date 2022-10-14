using System;
namespace TP3;

public class Persona
{
    //ATRIBUTO/S ---
    public int Id;
    public string Nombre;
    public string Domicilio;
    public string Telefono;

    //CONSTRUCTOR ---
    public Persona(int _Id, string _Nombre, string _Domicilio, string _Telefono)
    {
        Id = _Id;
        Nombre = _Nombre;
        Domicilio = _Domicilio;
        Telefono = _Telefono;
    }
}

public class Cliente : Persona
{
    // ATRIBUTO/S ---
    public string Datos_Referencia_Direccion;

    //CONSTRUCTOR ---
    public Cliente(int _Id, string _Nombre, string _Domicilio, string _Telefono, string _Datos_Referencia_Direccion) : base(_Id, _Nombre, _Domicilio, _Telefono)
    {
        Datos_Referencia_Direccion = _Datos_Referencia_Direccion;
    }
}

public class Cadete : Persona
{
    // ATRIBUTO/S ---
    public List<Pedido> Lista_Pedido;

    // METODO/S ---
    public void Agregar_Pedido(Pedido _Pedido)
    {
        Lista_Pedido.Add(_Pedido);
    }
    public void Eliminar_Pedido(int _Id)
    {
        Pedido? Pedido_1 = this.Lista_Pedido.Find( Pedido => Pedido.Id == _Id);

        if (Pedido_1 != null && !Pedido_1.Estado)
        {
            Lista_Pedido.Remove(Pedido_1);
        }
    }

    //CONSTRUCTOR ---
    public Cadete(int _Id, string _Nombre, string _Domicilio, string _Telefono) : base(_Id, _Nombre, _Domicilio, _Telefono)
    {
        Lista_Pedido = new List<Pedido>();
    }
}