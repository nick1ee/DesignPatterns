using FactoryPattern.Models;

namespace FactoryPattern.AbstractFactory
{
    public class ChingHsinTeaFactory : TeaFactory
    {
        public override GreenTea BrewGreenTea()
        {
            return new ChingHsinGreenTea();
        }

        public override RedTea BrewRedTea()
        {
            return new ChingHsinRedTea();
        }
    }
}