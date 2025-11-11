namespace DesignPatterns.Adapter.Models;

public sealed class AmazonSES
{
    public void SendEmail()
    {
        string message = "Send e-mail with AmazonSES";
        Console.WriteLine($"{message}\n");
    }
}