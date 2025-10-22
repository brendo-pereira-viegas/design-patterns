namespace DesignPatterns.AbstractFactory.Services;

/// <summary>
/// Implementa a interface IButton 
/// representar um botão no estilo Linux.
/// </summary>
internal sealed class LinuxButton : IButton
{
    public void Paint() =>
        Console.WriteLine("Drawing a Linux style button");
}