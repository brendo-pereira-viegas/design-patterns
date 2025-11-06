namespace DesignPatterns.FactoryMethod.Services;

internal sealed class SMSNotification : INotification
{
    public void Send()
    {
        string message = "Send SMS notification";
        Console.WriteLine(message);
    }
}