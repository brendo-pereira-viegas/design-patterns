namespace DesignPatterns.Adapter.Models;

public sealed class SMTPEmail : IEmailService
{
    public void Send()
    {
        string message = "Send e-mail with SMTP";
        Console.WriteLine($"{message}\n");
    }
}