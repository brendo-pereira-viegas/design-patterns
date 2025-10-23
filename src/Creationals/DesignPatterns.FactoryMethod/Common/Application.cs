namespace DesignPatterns.FactoryMethod.Common;

/// <summary>
/// Demonstra o uso do padrão Factory Method
/// para criação e execução de pagamento.
/// </summary>
internal static class Application
{
    internal static void Execute()
    {
        IPaymentMethod? paymentFactory = PaymentMethodFactory.Create(PaymentType.CREDIT_CARD);
        paymentFactory?.Execute();
        Console.ReadKey();
    }
}