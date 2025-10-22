namespace DesignPatterns.AbstractFactory.Common;

/// <summary>
/// Responsável por renderizar a interface 
/// usando objetos da família fornecida pela fábrica.
/// </summary>
internal sealed class Application
{
    private readonly IButton _button;

    internal Application(IGUIFactory factory) =>
        _button = factory.CreateButton();

    internal void RenderUI() =>
        _button.Paint();
}