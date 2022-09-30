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
    public void Cambiar_Estado_Pedido(int _Id_Pedido, int _Id_Cadete, bool _Estado);
    public void Trasladar_Pedido_Cadete(int _Id_Pedido, int _Cadete_Origen, Cadete _Cadete_Fin);

    public void Agregar_Cadete(Cadete _Cadete)
    {
        Lista_Cadete.Add(_Cadete);
    }
    
    public void Cambiar_Estado_Pedido(int _Id_Pedido, int _Id_Cadete, bool _Estado)
    {
        Cadete? Cadete = this.Lista_Cadete.Find(Cadete => Cadete.Id == _Id_Cadete);

        Pedido? Pedido = Cadete.Lista_Pedido.Find(Pedido => Pedido.Id == _Id_Pedido);

        if (Cadete != null && Pedido != null)
        {
            Pedido.Estado = _Estado;
        }

        /*
        foreach (var Cadete in Lista_Cadete)
        {
            if (Cadete.GetId() == _Id_Cadete)
            {
                foreach (var Pedido in Cadete.Lista_Pedido)
                {
                    if (Pedido.GetId() == _Id_Pedido)
                    {
                        Pedido.Estado = _Estado;
                    }
                }
            }
        }
        */
    }
    public void Trasladar_Pedido_Cadete(int _Id_Pedido, int _Id_Cadete_Origen, Cadete _Cadete_Fin)
    {
        Cadete? Cadete_Origen = this.Lista_Cadete.Find(Cadete => Cadete.Id == _Id_Cadete_Origen);

        Pedido? Pedido = Cadete_Origen.Lista_Pedido.Find(Pedido => Pedido.Id == _Id_Pedido);

        if (Cadete_Origen != null && Pedido != null)
        {
            _Cadete_Fin.Agregar_Pedido(Pedido);
            Cadete_Origen.Eliminar_Pedido(Pedido);
        }

        /*
        foreach (var Cadete in Lista_Cadete)
        {
            if (Cadete.Id == _Cadete_Origen.Id)
            {
                foreach (var Pedido in Cadete.Lista_Pedido)
                {
                    if (Pedido.Id == _Id_Pedido)
                    {
                        _Cadete_Fin.Agregar_Pedido(Pedido);
                        _Cadete_Origen.Eliminar_Pedido(_Id_Pedido);
                    }
                }
            }
        }
        */
    }

    // CONSTRUCTOR ---
    public Cadeteria (string _Nombre, string _Telefono)
    {
        Nombre = _Nombre;
        Telefono = _Telefono;
    }

}