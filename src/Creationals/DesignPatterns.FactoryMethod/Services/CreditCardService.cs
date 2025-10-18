namespace DesignPatterns.FactoryMethod.Services;

internal sealed class CreditCardService : IPaymentMethod
{
    public void Execute() =>
        Console.WriteLine("Credit Card... Running");
}