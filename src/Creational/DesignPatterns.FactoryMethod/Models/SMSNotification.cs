namespace DesignPatterns.FactoryMethod.Models;

internal sealed class SMSNotification : INotification
{
    public void Send()
    {
        string message = "Send SMS notification";
        Console.WriteLine(message);
    }
}