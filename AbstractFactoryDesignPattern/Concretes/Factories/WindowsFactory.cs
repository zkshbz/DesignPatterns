using AbstractFactoryDesignPattern.Abstracts;
using AbstractFactoryDesignPattern.Abstracts.Factories;
using AbstractFactoryDesignPattern.Concretes.ForWindows;

namespace AbstractFactoryDesignPattern.Concretes.Factories;

public class WindowsFactory : IUIFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("Windows Button");
        return new WindowsButton();
    }

    public ICheckBox CreateCheckBox()
    {
        Console.WriteLine("Windows CheckBox");
        return new WindowsCheckBox();
    }
}