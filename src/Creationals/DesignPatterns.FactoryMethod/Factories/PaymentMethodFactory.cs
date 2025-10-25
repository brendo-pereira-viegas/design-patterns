namespace DesignPatterns.FactoryMethod.Factories;

/// <summary>
/// Responsible for creating instances 
/// based on the provided
/// payment type.
/// </summary>
internal static class PaymentMethodFactory
{
    /// <summary>
    /// Generates a payment 
    /// method instance.
    /// </summary>
    internal static IPaymentMethod? Create(PaymentType payment) =>
        payment switch
        {
            PaymentType.DEBIT_CARD => new DebitCardService(),
            PaymentType.CREDIT_CARD => new CreditCardService(),
            _ => null
        };
}