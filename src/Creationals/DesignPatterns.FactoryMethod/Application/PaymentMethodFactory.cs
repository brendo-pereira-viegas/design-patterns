namespace DesignPatterns.FactoryMethod.Application;

internal static class PaymentMethodFactory
{
    internal static IPaymentMethod? Create(int payment) =>
        payment switch
        {
            1 => new DebitCardService(),
            2 => new CreditCardService(),
            _ => null
        };
}