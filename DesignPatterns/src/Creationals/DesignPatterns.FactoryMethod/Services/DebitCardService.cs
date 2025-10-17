namespace DesignPatterns.FactoryMethod.Services;

internal sealed class DebitCardService : IPaymentMethod
{
    public void Execute() =>
        Console.WriteLine("Debit Card... Running");
}