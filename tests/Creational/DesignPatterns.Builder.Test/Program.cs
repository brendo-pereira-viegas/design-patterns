Address builder = new AddressBuilder()
    .WithState("California")
    .WithStreet("Lombard")
    .Build();

Console.WriteLine($"{builder.State}...\n");
Console.WriteLine($"{builder.Street}...\n");

Console.ReadKey();