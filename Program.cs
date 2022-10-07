using System;
namespace TP3;

public static class Program 
{
    public static void Main(string[] args)
    {
        Cliente Client1, Client2;
        Pedido Ped1, Ped2;
        Cadete Cadet1, Cadet2;
        Cadeteria Cadeteria1;

        Client1 = new Cliente(00, "Pepe", "Av.Gen", 000001, "Black");
        Client2 = new Cliente(01, "Sasa", "Av.Yen", 000002, "White");

        Ped1 = new Pedido(00, "Pepas", Client1, 100, 0);
        Ped2 = new Pedido(01, "Salsa", Client2, 100, 0);

        Cadet1 = new Cadete(00, "Jose", "Joselia", 000400);
        Cadet2 = new Cadete(01, "Maria", "Gardenia", 000500);

        Cadeteria1 = new Cadeteria("Sand", 100000);

        Cadet1.Agregar_Pedido(Ped1);
        Cadet1.Agregar_Pedido(Ped2);

        Cadet2.Agregar_Pedido(Ped1);
        Cadet2.Agregar_Pedido(Ped2);

        Cadeteria1.Agregar_Cadete(Cadet1);
        Cadeteria1.Agregar_Cadete(Cadet2);

        Cadeteria1.Informe_Jornada();       
    }
}