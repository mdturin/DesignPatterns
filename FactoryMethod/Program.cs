using FactoryMethod;

Console.WriteLine("Concrete Creator 1: ");
ClientCode(new ConcreteCreator1());
Console.WriteLine();

Console.WriteLine("Concrete Creator 2: ");
ClientCode(new ConcreteCreator2());

void ClientCode(Creator creator)
{
    Console.WriteLine("Client: " + creator.SomeOperation());
}