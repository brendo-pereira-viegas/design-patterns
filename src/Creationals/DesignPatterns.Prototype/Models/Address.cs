namespace DesignPatterns.Prototype.Models;

internal sealed class Address : IPrototype
{
    public string? PostalCode { get; set; }

    public IPrototype Clone() => (IPrototype)MemberwiseClone();
}