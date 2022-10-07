// See https://aka.ms/new-console-template for more information
using System;
namespace TP3;
public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        try
        {
            Logger.Info("Info...");
            System.Console.ReadKey();

        }
        catch (Exception ex)
        {
            Logger.Error(ex, "Error...");
        }

        NLog.LogManager.Shutdown();
    }
}  