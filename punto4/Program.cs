﻿public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        try
        {
           Logger.Info("Hello world");
           Logger.Debug("pal Debug");
           Logger.Warn("warn");
           System.Console.ReadKey();
        }
        catch (Exception ex)
        {
           Logger.Error(ex, "Goodbye cruel world");
        }

        try 
        {
           Logger.Debug("pal Debug");
           System.Console.ReadKey();
        }
        catch (Exception ex)
        {
           Logger.Error(ex, "Goodbye cruel world");
        }
    }
}