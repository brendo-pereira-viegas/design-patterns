namespace DesignPatterns.FactoryMethod.Interfaces;

/// <summary>
/// Each concrete implementation defines
/// how a specific payment 
/// is processed.
/// </summary>
internal interface IPaymentMethod
{
    /// <summary>
    /// Executes the payment process.
    /// </summary>
    void Execute();
}