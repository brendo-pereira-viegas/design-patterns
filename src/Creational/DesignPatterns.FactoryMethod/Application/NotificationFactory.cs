namespace DesignPatterns.FactoryMethod.Application;

public static class NotificationFactory
{
    public static INotification? Create(int notification) =>
        notification switch
        {
            1 => new SMSNotification(),
            2 => new EmailNotification(),
            _ => null
        };
}