using System;
namespace TP3;

public class Cadeteria
{
    // ATRIBUTO/S ---
    public string Nombre;
    public string Telefono;
    public List<Cadete> Lista_Cadete;

    // METODO/S ---
    public Agregar_Cadete(Cadete _Cadete);


    public Agregar_Cadete(Cadete _Cadete)
    {
        Lista_Cadete.Add(_Cadete);
    }

    // CONSTRUCTOR ---
    public Cadeteria (string _Nombre, string _Telefono)
    {
        Nombre = _Nombre;
        Telefono = _Telefono;
    }

}