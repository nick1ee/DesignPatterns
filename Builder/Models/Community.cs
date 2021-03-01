using System;
using System.Collections.Generic;

namespace Builder.Models
{
    public class Community
    {
        public List<House> houses;

        public Community(List<House> houses)
        {
            this.houses = houses;
        }

        public void Display()
        {
            Console.WriteLine($"There are {houses.Count} houses in this Community. Here comes the detail.");
            houses.ForEach(h => h.Display());
        }
    }
}