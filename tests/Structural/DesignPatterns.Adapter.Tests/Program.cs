// Legacy implementation
SMTPEmail smtp = new();
smtp.Send();

// New implementation
AmazonSES amazonSES = new();
AmazonSESAdapter amazonAdapter = new(amazonSES);
amazonAdapter.Send();

Console.ReadKey();