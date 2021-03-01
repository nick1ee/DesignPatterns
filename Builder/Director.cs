using System.Collections.Generic;
using Builder.Models;

namespace Builder
{
    public class Director
    {
        public Community BuildCommunity(params IHouseBuilder[] builders)
        {
            var houses = new List<House>();

            foreach (var builder in builders)
            {
                var house = builder.Build();
                houses.Add(house);
            }

            var commnuity = new Community(houses);
            return commnuity;
        }
    }
}