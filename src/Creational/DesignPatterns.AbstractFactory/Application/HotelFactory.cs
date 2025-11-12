namespace DesignPatterns.AbstractFactory.Application;

public sealed class HotelFactory : IFactory
{
    public IInvoice CreateInvoice() => new HotelInvoice();

    public IReceipt CreateReceipt() => new HotelReceipt();
}