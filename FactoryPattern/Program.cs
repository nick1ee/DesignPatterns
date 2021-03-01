using System;
using FactoryPattern.AbstractFactory;
using FactoryPattern.FactoryMethod;
using FactoryPattern.SimpleFactory;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void DemoAbstractFactory()
        {
            var factory = new ChingHsinTeaFactory();
            var greenTead = factory.BrewGreenTea();
            var redTea = factory.BrewRedTea();

            // 50嵐, 茶湯會... 等等都可以有自己的 Factory
        }

        static void DemoFactoryMethod()
        {
            var greenTeaFactory = new GreenTeaFactory();
            var greenTea = greenTeaFactory.BrewTea();

            var redTeaFactory = new RedTeaFactory();
            var redTea = redTeaFactory.BrewTea();
        }

        static void DemoSimpleFactory()
        {
            var tea = TeaShop.BrewTea("Green");
        }
    }
}
