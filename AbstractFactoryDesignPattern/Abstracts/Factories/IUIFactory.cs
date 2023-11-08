namespace AbstractFactoryDesignPattern.Abstracts.Factories;

public interface IUIFactory
{
    IButton CreateButton();
    ICheckBox CreateCheckBox();
}
