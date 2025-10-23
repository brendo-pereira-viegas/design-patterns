namespace DesignPatterns.FactoryMethod.Factories;

/// <summary>
/// Responsável por criar instâncias
/// com base no tipo de pagamento fornecido.
/// </summary>
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