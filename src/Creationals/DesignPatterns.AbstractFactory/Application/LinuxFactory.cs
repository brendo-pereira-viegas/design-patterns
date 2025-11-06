namespace DesignPatterns.AbstractFactory.Application;

internal sealed class LinuxFactory : IGUIFactory
{
    public IButton CreateButton() => new LinuxButton();
}