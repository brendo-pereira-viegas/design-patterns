namespace DesignPatterns.Singleton.Services;

public sealed class SQLServer : IDatabase
{
    private static SQLServer? s_instance;

    private SQLServer() { }

    public void Connect()
    {
        string message = "Connecting...";
        Console.WriteLine($"{message}\n");
    }

    public void Disconnect()
    {
        string message = "Disconnect...";
        Console.WriteLine($"{message}\n");
    }

    public static SQLServer GetInstance() =>
        s_instance ??= new SQLServer();
}