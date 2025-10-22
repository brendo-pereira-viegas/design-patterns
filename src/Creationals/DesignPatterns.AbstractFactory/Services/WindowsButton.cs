namespace DesignPatterns.AbstractFactory.Services;

/// <summary>
/// Implementa a interface IButton 
/// representar um botão no estilo Windows.
/// </summary>
internal sealed class WindowsButton : IButton
{
    public void Paint() =>
        Console.WriteLine("Drawing a Windows style button");
}