using System;
using FactoryPattern.Models;

namespace FactoryPattern.FactoryMethod
{
    public class GreenTeaFactory : ITeaFactory
    {
        public Tea BrewTea()
        {
            return new GreenTea();
        }
    }
}