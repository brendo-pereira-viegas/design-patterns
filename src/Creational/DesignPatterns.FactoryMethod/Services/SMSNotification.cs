namespace DesignPatterns.FactoryMethod.Services;

public sealed class SMSNotification : INotification
{
    public void Send()
    {
        string message = "Send SMS notification";
        Console.WriteLine($"{message}\n");
    }
}