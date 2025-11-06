namespace DesignPatterns.Builder.Application;

internal sealed class ConcreteBuilder : IBuilder
{
    private readonly User _product = new();

    public IBuilder WithUsername(string username)
    {
        _product.Username = username;
        return this;
    }

    public IBuilder WithPassword(string password)
    {
        _product.Password = password;
        return this;
    }

    public User Build() => _product;
}