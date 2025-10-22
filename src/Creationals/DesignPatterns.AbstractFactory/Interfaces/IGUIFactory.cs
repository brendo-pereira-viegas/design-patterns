namespace DesignPatterns.AbstractFactory.Interfaces;

/// <summary>
/// Define uma interface responsável 
/// por criar objetos da mesma família.
/// </summary>
internal interface IGUIFactory { IButton CreateButton(); }