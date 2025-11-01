namespace DesignPatterns.FactoryMethod.Services;

internal sealed class DebitCardService : IPaymentMethod
{
    public string ProcessPayment() => "Debit Card... Running";
}