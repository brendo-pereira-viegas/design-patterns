namespace DesignPatterns.AbstractFactory.Services;

/// <summary>
/// Implements the <see cref="IButton"/> interface
/// to represent a button in
/// the Windows style.
/// </summary>
internal sealed class WindowsButton : IButton
{
    /// <summary>
    /// Renders the button on
    /// the user interface.
    /// </summary>
    public void Paint() =>
        Console.WriteLine("Drawing a Windows style button");
}