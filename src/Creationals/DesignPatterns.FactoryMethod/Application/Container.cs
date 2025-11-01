namespace DesignPatterns.FactoryMethod.Application;

internal static class Container
{
    internal static void Execute()
    {
        Console.WriteLine(PaymentMethodFactory
            .Create(1)?
            .ProcessPayment()
        );

        Console.WriteLine(PaymentMethodFactory
            .Create(2)?
            .ProcessPayment()
        );
    }
}