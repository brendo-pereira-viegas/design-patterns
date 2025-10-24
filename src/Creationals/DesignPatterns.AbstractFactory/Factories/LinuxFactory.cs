namespace DesignPatterns.AbstractFactory.Factories;

/// <summary>
/// Creates concrete UI objects 
/// that belong to the Linux
/// product family.
/// </summary>
internal sealed class LinuxFactory : IGUIFactory
{
    /// <summary>
    /// Creates a concrete button.
    /// </summary>
    public IButton CreateButton() =>
        new LinuxButton();
}