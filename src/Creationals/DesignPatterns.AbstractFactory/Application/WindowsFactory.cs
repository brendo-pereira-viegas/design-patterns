namespace DesignPatterns.AbstractFactory.Application;

internal sealed class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
}