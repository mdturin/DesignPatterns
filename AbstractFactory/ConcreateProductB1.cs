namespace AbstractFactory
{
    public class ConcreateProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of B1 collborating with ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of product B1";
        }
    }
}