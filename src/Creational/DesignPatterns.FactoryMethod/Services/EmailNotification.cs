namespace DesignPatterns.FactoryMethod.Services;

public sealed class EmailNotification : INotification
{
    public void Send()
    {
        string message = "Send email notification";
        Console.WriteLine($"{message}\n");
    }
}