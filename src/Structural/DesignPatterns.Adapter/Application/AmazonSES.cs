namespace DesignPatterns.Adapter.Application;

public sealed class AmazonSES
{
    public void SendEmail()
    {
        string message = "Send AmazonSES...";
        Console.WriteLine($"{message}\n");
    }
}