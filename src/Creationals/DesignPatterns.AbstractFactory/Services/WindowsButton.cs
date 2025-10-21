namespace DesignPatterns.AbstractFactory.Services;

internal sealed class WindowsButton : IButton
{
    public void Paint() =>
        Console.WriteLine("Drawing a Windows style button");
}