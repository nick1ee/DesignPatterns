using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoBuildCommunity();
        }

        static void DemoBuildCommunity()
        {
            var community = new Director().BuildCommunity
            (
                new HouseBuilder().BuildRoom(4).BuildToilet(2).BuildWindow(3).BuildGarden(2),
                new HouseBuilder().BuildRoom(2).BuildWindow(2).BuildGarden(2),
                new HouseBuilder().BuildToilet(2).BuildWindow(1).BuildGarden(5),
                new HouseBuilder().BuildRoom(3).BuildToilet(6).BuildWindow(1)
            );

            community.Display();
        }

        static void DemoBuildAHouse()
        {
            var house = new HouseBuilder()
                        .BuildRoom(3)
                        .BuildToilet(2)
                        .BuildGarden(1)
                        .BuildWindow(4)
                        .Build();

            house.Display();
        }
    }
}
