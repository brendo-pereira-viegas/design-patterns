namespace DesignPatterns.FactoryMethod.Application;

public sealed class SMSFactory : IFactory
{
    public INotification Create() => new SMSNotification();
}