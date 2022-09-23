using System;
namespace TP3;

public class Cadeteria
{
    // ATRIBUTO/S ---
    public string Nombre;
    public string Telefono;
    public List<Cadete> Lista_Cadete;

    // METODO/S ---
    public void Agregar_Cadete(Cadete _Cadete);
    public void Cambiar_Estado_Pedido(int _Id_Pedido);

    public void Agregar_Cadete(Cadete _Cadete)
    {
        Lista_Cadete.Add(_Cadete);
    }
    public void Cambiar_Estado_Pedido(int _Id_Pedido)
    {

    }

    // CONSTRUCTOR ---
    public Cadeteria (string _Nombre, string _Telefono)
    {
        Nombre = _Nombre;
        Telefono = _Telefono;
    }

}

/*
     ___________                     ___________
    |           |                   |           |
    |           |                   |           |
    |           |   |     |     |   |           |
    |           |   |     |     |   |           |
    |___________|   |_____|_____|   |___________|
            
*/