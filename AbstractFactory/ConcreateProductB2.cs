namespace AbstractFactory
{
    public class ConcreateProductB2 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of B2 collborating with ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of product B2";
        }
    }
}