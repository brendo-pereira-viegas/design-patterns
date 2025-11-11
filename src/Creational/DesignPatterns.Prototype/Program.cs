Document original = new() { Title = "Introduction" };
Document clone = (Document)original.Clone();

Console.WriteLine(clone.Title);
Console.ReadKey();