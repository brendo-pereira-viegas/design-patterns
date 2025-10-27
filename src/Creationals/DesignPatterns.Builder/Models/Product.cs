namespace DesignPatterns.Builder.Models;

internal sealed class Product
{
    internal string? Name { get; set; }
    internal int Quantity { get; set; }
    internal decimal Price { get; set; }

    public override string ToString() =>
        $"Name: {Name} - Quantity: {Quantity} - Price: {Price}";
}