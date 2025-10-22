namespace DesignPatterns.AbstractFactory.Factories;

/// <summary>
/// Cria objetos concretos da 
/// família Windows, como WindowsButton.
/// </summary>
internal sealed class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() =>
        new WindowsButton();
}