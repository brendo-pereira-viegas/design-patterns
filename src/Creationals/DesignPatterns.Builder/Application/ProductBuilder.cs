namespace DesignPatterns.Builder.Application;

internal sealed class ProductBuilder : IBuilder
{
    private readonly Product _product = new();

    public IBuilder WithName(string name)
    {
        _product.Name = name;
        return this;
    }

    public IBuilder WithPrice(decimal price)
    {
        _product.Price = price;
        return this;
    }

    public Product Build() => _product;
}