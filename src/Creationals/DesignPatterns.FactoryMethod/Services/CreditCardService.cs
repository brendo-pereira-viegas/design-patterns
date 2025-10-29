namespace DesignPatterns.FactoryMethod.Services;

internal sealed class CreditCardService : IPaymentMethod
{
    public string Execute() => "Credit Card... Running";
}