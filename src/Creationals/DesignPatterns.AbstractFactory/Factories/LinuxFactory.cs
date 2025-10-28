namespace DesignPatterns.AbstractFactory.Factories;

internal sealed class LinuxFactory : IGUIFactory
{
    public IButton CreateButton() => new LinuxButton();
}