namespace DesignPatterns.FactoryMethod.Interfaces;

/// <summary>
/// Cada implementação concreta desta interface 
/// define como um pagamento específico é processado.
/// </summary>
internal interface IPaymentMethod { void Execute(); }