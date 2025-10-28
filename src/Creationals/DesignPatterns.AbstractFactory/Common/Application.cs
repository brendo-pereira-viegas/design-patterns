namespace DesignPatterns.AbstractFactory.Common;

internal sealed class Application
{
    private readonly IButton _button;

    internal Application(IGUIFactory factory) =>
        _button = factory.CreateButton();

    internal void RenderUI() =>
        _button.Paint();
}