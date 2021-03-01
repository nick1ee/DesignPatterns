using FactoryPattern.Models;

namespace FactoryPattern.AbstractFactory
{
    public abstract class TeaFactory
    {
        public abstract GreenTea BrewGreenTea();

        public abstract RedTea BrewRedTea();
    }
}