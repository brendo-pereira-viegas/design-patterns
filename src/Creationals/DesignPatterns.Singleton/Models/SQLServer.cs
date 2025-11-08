namespace DesignPatterns.Singleton.Models;

internal sealed class SQLServer : IDatabase
{
    private static SQLServer? s_instance;

    public void Connect() =>
        Console.WriteLine("Connecting...");

    public void Disconnect() =>
        Console.WriteLine("Disconnecting...");

    internal static SQLServer GetInstance() =>
        s_instance ??= new SQLServer();
}