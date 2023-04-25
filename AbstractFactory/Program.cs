using AbstractFactory;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Client: first factory...");
ClientMethod(new ConcreteFactory1());
Console.WriteLine();

Console.WriteLine("Client: second factory...");
ClientMethod(new ConcreteFactory2());
Console.WriteLine();

void ClientMethod(IAbstractFactory factory)
{
    var productA = factory.CreateProductA();
    var productB = factory.CreateProductB();
    Console.WriteLine(productB.UsefulFunctionB());
    Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
}