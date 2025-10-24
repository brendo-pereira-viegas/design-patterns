namespace DesignPatterns.AbstractFactory.Common;

/// <summary>
/// Responsible for rendering the UI using
/// products created by the provided
/// concrete factory.
/// </summary>
internal sealed class Application
{
    /// <summary>
    /// Button instance belonging
    /// to the product family.
    /// </summary>
    private readonly IButton _button;

    /// <summary>
    /// Creating UI components.
    /// </summary>
    internal Application(IGUIFactory factory) =>
        _button = factory.CreateButton();

    /// <summary>
    /// Renders the user interface by 
    /// invoking the paint method.
    /// </summary>
    internal void RenderUI() =>
        _button.Paint();
}