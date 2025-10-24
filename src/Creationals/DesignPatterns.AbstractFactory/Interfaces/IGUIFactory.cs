namespace DesignPatterns.AbstractFactory.Interfaces;

/// <summary>
/// Defines an interface responsible for
/// creating objects belonging to the
/// same product family.
/// </summary>
internal interface IGUIFactory
{
    /// <summary>
    /// Creates a button object
    /// belonging to the family.
    /// </summary>
    IButton CreateButton();
}