namespace DesignPatterns.Builder.Builders;

internal class ProductBuilder
{
    private readonly Product _product = new();

    internal ProductBuilder WithName(string name)
    {
        _product.Name = name;
        return this;
    }

    internal ProductBuilder WithQuantity(int quantity)
    {
        _product.Quantity = quantity;
        return this;
    }

    internal ProductBuilder WithPrice(decimal price)
    {
        _product.Price = price;
        return this;
    }

    internal Product Build() => _product;
}