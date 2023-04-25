using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreateProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreateProductB1();
        }
    }
}
