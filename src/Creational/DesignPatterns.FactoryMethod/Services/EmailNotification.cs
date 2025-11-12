namespace DesignPatterns.FactoryMethod.Services;

public sealed class EmailNotification : INotification
{
    public void Send()
    {
        string message = "Send Email...";
        Console.WriteLine($"{message}\n");
    }
}