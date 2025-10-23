namespace DesignPatterns.FactoryMethod.Services;

/// <summary>
/// Representa o produto concreto
/// no padrão Factory Method.
/// </summary>
internal sealed class CreditCardService : IPaymentMethod
{
    public void Execute() =>
        Console.WriteLine("Credit Card... Running");
}