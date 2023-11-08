using AbstractFactoryDesignPattern.Abstracts;
using AbstractFactoryDesignPattern.Abstracts.Factories;
using AbstractFactoryDesignPattern.Concretes.ForMac;

namespace AbstractFactoryDesignPattern.Concretes.Factories;

public class MacFactory : IUIFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("Mac button created");
        return new MacButton();
    }

    public ICheckBox CreateCheckBox()
    {
        Console.WriteLine("Mac check box created");
        return new MacCheckBox();
    }
}