namespace DesignPatterns.FactoryMethod.Application;

public sealed class EmailFactory : IFactory
{
    public INotification Create() => new EmailNotification();
}