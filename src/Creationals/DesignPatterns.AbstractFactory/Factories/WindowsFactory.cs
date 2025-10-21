namespace DesignPatterns.AbstractFactory.Factories;

internal sealed class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() =>
        new WindowsButton();
}