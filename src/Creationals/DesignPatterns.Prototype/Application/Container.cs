namespace DesignPatterns.Prototype.Application;

internal static class Container
{
    internal static void Execute()
    {
        Address address = new() { PostalCode = "87654-029" };
        Console.WriteLine($"Address: {address.PostalCode}");

        Address clone = (Address)address.Clone();
        Console.WriteLine($"Prototype: {clone.PostalCode = "55555-555"}");
    }
}