namespace DesignPatterns.Builder.Interfaces;

public interface IBuilder
{
    Address Build();
    IBuilder WithState(string state);
    IBuilder WithStreet(string street);
}