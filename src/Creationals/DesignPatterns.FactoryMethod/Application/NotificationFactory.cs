namespace DesignPatterns.FactoryMethod.Application;

internal static class NotificationFactory
{
    internal static INotification? Create(int notification) =>
        notification switch
        {
            1 => new SMSNotification(),
            2 => new EmailNotification(),
            _ => null
        };
}