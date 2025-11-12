namespace DesignPatterns.AbstractFactory.Services;

public sealed class HotelReceipt : IReceipt
{
    public void Print()
    {
        string message = "Generating receipt...";
        Console.WriteLine($"{message}\n");
    }
}