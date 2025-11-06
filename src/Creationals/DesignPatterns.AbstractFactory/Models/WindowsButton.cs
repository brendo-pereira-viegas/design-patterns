namespace DesignPatterns.AbstractFactory.Models;

internal sealed class WindowsButton : IButton
{
    public void Paint()
    {
        string message = "Drawing a Windows style button";
        Console.WriteLine(message);
    }
}