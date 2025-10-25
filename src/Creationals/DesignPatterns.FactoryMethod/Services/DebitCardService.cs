namespace DesignPatterns.FactoryMethod.Services;

/// <summary>
/// Represents the concrete product
/// in the Factory Method
/// pattern.
/// </summary>
internal sealed class DebitCardService : IPaymentMethod
{
    /// <summary>
    /// Executes the payment process.
    /// </summary>
    public void Execute() =>
        Console.WriteLine("Debit Card... Running");
}