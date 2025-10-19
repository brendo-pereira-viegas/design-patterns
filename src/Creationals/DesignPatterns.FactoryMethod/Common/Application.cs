namespace DesignPatterns.FactoryMethod.Common;

internal static class Application
{
    internal static void Execute()
    {
        IPaymentMethod? paymentFactory = PaymentMethodFactory.Create(PaymentType.CREDIT_CARD);
        paymentFactory?.Execute();
        Console.ReadKey();
    }
}