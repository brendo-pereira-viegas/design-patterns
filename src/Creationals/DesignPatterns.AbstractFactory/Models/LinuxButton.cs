namespace DesignPatterns.AbstractFactory.Models;

internal sealed class LinuxButton : IButton
{
    public void Paint()
    {
        string message = "Drawing a Linux style button";
        Console.WriteLine(message);
    }
}