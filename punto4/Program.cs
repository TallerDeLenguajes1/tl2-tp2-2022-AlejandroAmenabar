public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        try
        {
           Logger.Info("inforr");
           Logger.Debug("debug");
           Logger.Warn("warning");
           Logger.Fatal("fatality");
           Logger.Trace("traceK");
           System.Console.ReadKey();
        }
        catch (Exception ex)
        {
           Logger.Error(ex, "Goodbye cruel world");
        }
    }
}  
