using System.IO;
namespace TP3;

public static class Program 
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main(string[] args)
    {
        Pedido Ped1, Ped2;
        Cadeteria Cadeteria1;

        try
        {
            Cadeteria1 = new Cadeteria("Sand", "1000", Read_Cadetes());


            Cadeteria1.Informe_Jornada();              
        }
        catch(FileNotFoundException)
        {
            Logger.Error("Archivo no Encontrado!");
        }
        catch (Exception e)
        {
            Logger.Error("Exception encontrada! ", e);
        }
        NLog.LogManager.Shutdown();
    }

    public static List<Cadete> Read_Cadetes()
    {
        string? Ruta_Cadete = "Cadete.csv";
        int Id = 0;
        List<Cadete> Lista_Cadetes = new List<Cadete>();

        using (StreamReader sr = new StreamReader(Ruta_Cadete))
        {
            string? line = sr.ReadLine();

            while (line != null)
            {
                string[]? Datos_Cadete = line.Split(";");
                Int32.TryParse(Datos_Cadete[0], out Id);

                Lista_Cadetes.Add(new Cadete(Id, Datos_Cadete[1], Datos_Cadete[2], Datos_Cadete[3]));

                line = sr.ReadLine();
            }
        }
        return(Lista_Cadetes);
    }

    public static List<Pedido> Read_Pedido()
    {
        
    }
}