namespace DesignPatterns.Builder.Interfaces;

internal interface IBuilder
{
    Product Build();
    IBuilder WithName(string name);
    IBuilder WithPrice(decimal price);
}