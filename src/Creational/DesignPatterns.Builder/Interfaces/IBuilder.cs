namespace DesignPatterns.Builder.Interfaces;

internal interface IBuilder
{
    User Build();
    IBuilder WithUsername(string username);
    IBuilder WithPassword(string password);
}