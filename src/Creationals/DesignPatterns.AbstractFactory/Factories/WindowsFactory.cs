namespace DesignPatterns.AbstractFactory.Factories;

/// <summary>
/// Creates concrete UI objects 
/// that belong to the Windows
/// product family.
/// </summary>
internal sealed class WindowsFactory : IGUIFactory
{
    /// <summary>
    /// Creates a concrete button.
    /// </summary>
    public IButton CreateButton() =>
        new WindowsButton();
}