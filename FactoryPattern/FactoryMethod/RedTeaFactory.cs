using FactoryPattern.Models;

namespace FactoryPattern.FactoryMethod
{
    public class RedTeaFactory : ITeaFactory
    {
        public Tea BrewTea()
        {
            return new RedTea();
        }

    }
}