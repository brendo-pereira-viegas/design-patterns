namespace DesignPatterns.FactoryMethod.Application;

internal static class Container
{
    internal static void Execute()
    {
        IPaymentMethod? debitCard = PaymentMethodFactory.Create(1);
        Console.WriteLine(debitCard?.ProcessPayment());

        IPaymentMethod? creditCard = PaymentMethodFactory.Create(2);
        Console.WriteLine(creditCard?.ProcessPayment());
    }
}