namespace DesignPatterns.FactoryMethod.Services;

internal sealed class DebitCardService : IPaymentMethod
{
    public string Execute() => "Debit Card... Running";
}