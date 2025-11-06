namespace DesignPatterns.FactoryMethod.Services;

internal sealed class EmailNotification : INotification
{
    public void Send()
    {
        string message = "Send e-mail notification";
        Console.WriteLine(message);
    }
}