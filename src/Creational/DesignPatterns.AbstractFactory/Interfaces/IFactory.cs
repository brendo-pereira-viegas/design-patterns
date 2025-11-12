namespace DesignPatterns.AbstractFactory.Interfaces;

internal interface IFactory
{
    IInvoice CreateInvoice();
    IReceipt CreateReceipt();
}