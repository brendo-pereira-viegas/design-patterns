namespace DesignPatterns.FactoryMethod.Services;

internal sealed class CreditCardService : IPaymentMethod
{
    public string ProcessPayment() => "Credit Card... Running";
}