namespace DesignPatterns.Prototype.Application;

internal static class Container
{
    internal static void Execute()
    {
        Document original = new() { Title = "Introduction" };
        Console.WriteLine(original.Title);

        Document clone = (Document)original.Clone();
        Console.WriteLine(clone.Title = "Conclusion");
    }
}