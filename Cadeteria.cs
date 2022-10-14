using System;
namespace TP3;

public class Cadeteria
{
    // ATRIBUTO/S ---
    public string Nombre;
    public string Telefono;
    public List<Cadete> Lista_Cadete;

    // METODO/S ---
    public void Agregar_Cadete(Cadete _Cadete)
    {
        Lista_Cadete.Add(_Cadete);
    }
    
    public void Cambiar_Estado_Pedido(int _Id_Pedido, int _Id_Cadete, bool _Estado)
    {
        Cadete? Cadete = this.Lista_Cadete.Find(Cadete => Cadete.Id == _Id_Cadete);

        Pedido? Pedido = Cadete?.Lista_Pedido.Find(Pedido => Pedido.Id == _Id_Pedido);

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

        Pedido? Pedido = Cadete_Origen?.Lista_Pedido.Find(Pedido => Pedido.Id == _Id_Pedido);

        if (Cadete_Origen != null && Pedido != null)
        {
            _Cadete_Fin.Agregar_Pedido(Pedido);
            Cadete_Origen.Eliminar_Pedido(Pedido.Id);
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

    public void Informe_Jornada()
    {
        int Cantidad_Pedidos_Cadete_Mostrar = 0, Cantidad_Cadete = 0, Cantidad_Pedidos_Cadete = 0;
        float Monto_Ganado_Cadete = 0, Monto_Total_Jornada = 0; 
        
        foreach (Cadete Cadete in Lista_Cadete)
        {   
            Cantidad_Cadete++;
            Cantidad_Pedidos_Cadete_Mostrar = 0;
            Monto_Ganado_Cadete = 0;

            foreach (Pedido Pedido in Cadete.Lista_Pedido)
            {
                Cantidad_Pedidos_Cadete_Mostrar++;
                Cantidad_Pedidos_Cadete++;
                Monto_Ganado_Cadete += Pedido.Precio;
                Monto_Total_Jornada += Pedido.Precio;
            }

            Console.WriteLine("   [ Cadete | "+ Cadete.Nombre+" ]");
            Console.WriteLine("     Cantidad de pedidos : "+ Cantidad_Pedidos_Cadete_Mostrar);
            Console.WriteLine("     Monto obtenido : "+ Monto_Ganado_Cadete);

        }

        Console.WriteLine("   | Monto total de la Jornada $"+ Monto_Total_Jornada," |");

        if (Cantidad_Cadete != 0)
        {
            Console.WriteLine("   | Envio Promedio : "+(Cantidad_Pedidos_Cadete/Cantidad_Cadete)+" |");
        }
        
    }

    // CONSTRUCTOR ---
    public Cadeteria (string _Nombre, string _Telefono, List<Cadete> _Lista_Cadete)
    {
        Nombre = _Nombre;
        Telefono = _Telefono;
        Lista_Cadete = _Lista_Cadete;
    }

}