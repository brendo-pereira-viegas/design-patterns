namespace DesignPatterns.AbstractFactory.Services;

internal sealed class WindowsButton : IButton
{
    public string Paint() => "Drawing a Windows style button";
}