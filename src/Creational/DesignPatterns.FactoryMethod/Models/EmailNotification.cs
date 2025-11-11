namespace DesignPatterns.FactoryMethod.Models;

internal sealed class EmailNotification : INotification
{
    public void Send()
    {
        string message = "Send e-mail notification";
        Console.WriteLine(message);
    }
}