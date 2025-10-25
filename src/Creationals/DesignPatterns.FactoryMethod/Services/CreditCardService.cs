namespace DesignPatterns.FactoryMethod.Services;

/// <summary>
/// Represents the concrete product
/// in the Factory Method
/// pattern.
/// </summary>
internal sealed class CreditCardService : IPaymentMethod
{
    /// <summary>
    /// Executes the payment process.
    /// </summary>
    public void Execute() =>
        Console.WriteLine("Credit Card... Running");
}