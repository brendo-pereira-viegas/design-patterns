namespace DesignPatterns.AbstractFactory.Factories;

/// <summary>
/// Cria objetos concretos da 
/// família Linux, como LinuxButton.
/// </summary>
internal sealed class LinuxFactory : IGUIFactory
{
    public IButton CreateButton() =>
        new LinuxButton();
}