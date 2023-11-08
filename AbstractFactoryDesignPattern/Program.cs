// See https://aka.ms/new-console-template for more information


using AbstractFactoryDesignPattern.Abstracts.Factories;
using AbstractFactoryDesignPattern.Concretes.Factories;

IUIFactory windowsFactory = new WindowsFactory();
IUIFactory macFactory = new MacFactory();

windowsFactory.CreateButton();
macFactory.CreateButton();

windowsFactory.CreateCheckBox();
macFactory.CreateCheckBox();
