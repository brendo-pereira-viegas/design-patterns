namespace DesignPatterns.Builder.Application;

public sealed class AddressBuilder : IBuilder
{
    private readonly Address _address = new();

    public IBuilder WithState(string username)
    {
        _address.Street = username;
        return this;
    }

    public IBuilder WithStreet(string password)
    {
        _address.State = password;
        return this;
    }

    public Address Build() => _address;
}