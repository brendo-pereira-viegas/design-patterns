namespace DesignPatterns.Adapter.Services;

public sealed class SMTPEmail : IEmailService
{
    public void Send()
    {
        string message = "Send SMTP...";
        Console.WriteLine($"{message}\n");
    }
}