User builder = new ConcreteBuilder()
    .WithUsername("Johnny")
    .WithPassword("2a35W")
    .Build();

Console.WriteLine(builder.Username);
Console.WriteLine(builder.Password);
Console.ReadKey();