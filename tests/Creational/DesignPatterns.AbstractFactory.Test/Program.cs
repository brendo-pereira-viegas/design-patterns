HotelFactory factory = new();

factory
    .CreateInvoice()
    .Generate();

factory
    .CreateReceipt()
    .Print();

Console.ReadKey();