using System;
using FactoryPattern.Models;

namespace FactoryPattern.SimpleFactory
{
    public static class TeaShop
    {
        public static Tea BrewTea(string type)
        {
            switch (type)
            {
                case "Green":
                    return new GreenTea();
                case "Read":
                    return new RedTea();
                default:
                    throw new Exception("Unknown tea type.");
            }
        }
    }
}