namespace DesignPatterns.AbstractFactory.Application;

internal static class Container
{
    internal static void Execute()
    {
        string windowsButton = new WindowsFactory()
            .CreateButton()
            .Paint();

        Console.WriteLine(windowsButton);
    }
}