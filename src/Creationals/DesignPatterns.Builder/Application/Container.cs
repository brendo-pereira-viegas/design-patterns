namespace DesignPatterns.Builder.Application;

internal static class Container
{
    internal static void Execute()
    {
        Product builder = new ProductBuilder()
            .WithName("TV")
            .WithPrice(1500)
            .Build();

        Console.WriteLine($"Name: {builder.Name}");
        Console.WriteLine($"Price: {builder.Price}");
    }
}