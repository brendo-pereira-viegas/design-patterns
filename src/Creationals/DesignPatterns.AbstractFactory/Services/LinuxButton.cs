namespace DesignPatterns.AbstractFactory.Services;

internal sealed class LinuxButton : IButton
{
    public string Paint() => "Drawing a Linux style button";
}