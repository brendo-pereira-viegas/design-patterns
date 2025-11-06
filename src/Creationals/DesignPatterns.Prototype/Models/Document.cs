namespace DesignPatterns.Prototype.Models;

internal sealed class Document : IPrototype
{
    public required string Title { get; set; }

    public IPrototype Clone() => (IPrototype)MemberwiseClone();
}