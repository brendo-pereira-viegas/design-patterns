namespace DesignPatterns.AbstractFactory.Services;

internal sealed class LinuxButton : IButton
{
    public void Paint() =>
        Console.WriteLine("Drawing a Linux style button");
}