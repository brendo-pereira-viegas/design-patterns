namespace DesignPatterns.Adapter.Application;

public sealed class AmazonSESAdapter(AmazonSES amazonSES) : IEmailService
{
    public void Send() => amazonSES.SendEmail();
}