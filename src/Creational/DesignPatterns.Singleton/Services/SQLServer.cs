namespace DesignPatterns.Singleton.Services;

public sealed class SQLServer : IDatabase
{
    private static SQLServer? s_instance;

    public void Connect() =>
        Console.WriteLine("Connecting...\n");

    public void Disconnect() =>
        Console.WriteLine("Disconnecting...\n");

    public static SQLServer GetInstance() =>
        s_instance ??= new SQLServer();
}