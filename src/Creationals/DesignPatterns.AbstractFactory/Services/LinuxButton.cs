namespace DesignPatterns.AbstractFactory.Services;

/// <summary>
/// Implements the <see cref="IButton"/> interface
/// to represent a button in
/// the Linux style.
/// </summary>
internal sealed class LinuxButton : IButton
{
    /// <summary>
    /// Renders the button on
    /// the user interface.
    /// </summary>
    public void Paint() =>
        Console.WriteLine("Drawing a Linux style button");
}