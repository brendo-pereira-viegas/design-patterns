namespace DesignPatterns.AbstractFactory.Interfaces;

/// <summary>
/// Defines the interface for a button,
/// which will be implemented 
/// by concrete products.
/// </summary>
internal interface IButton
{
    /// <summary>
    /// Renders the button on
    /// the user interface.
    /// </summary>
    void Paint();
}