Product builder = new ProductBuilder()
    .WithName("TV")
    .WithQuantity(2)
    .WithPrice(1500)
    .Build();

Console.WriteLine(builder);
Console.ReadKey();