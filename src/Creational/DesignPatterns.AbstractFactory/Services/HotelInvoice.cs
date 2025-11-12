namespace DesignPatterns.AbstractFactory.Services;

public sealed class HotelInvoice : IInvoice
{
    public void Generate()
    {
        string message = "Generating invoice...";
        Console.WriteLine($"{message}\n");
    }
}