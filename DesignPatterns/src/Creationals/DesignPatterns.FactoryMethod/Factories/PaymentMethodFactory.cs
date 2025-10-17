namespace DesignPatterns.FactoryMethod.Factories;

internal static class PaymentMethodFactory
{
    internal static IPaymentMethod? Create(PaymentType payment) =>
        payment switch
        {
            PaymentType.DEBIT_CARD => new DebitCardService(),
            PaymentType.CREDIT_CARD => new CreditCardService(),
            _ => null
        };
}