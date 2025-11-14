namespace DesignPatterns.Prototype.Services;

public sealed class Document : IPrototype
{
    public string? Title { get; set; }

    public IPrototype Clone() => new Document() { Title = Title };
}