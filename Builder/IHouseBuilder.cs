using Builder.Models;

namespace Builder
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildRoom(int num);

        IHouseBuilder BuildWindow(int num);

        IHouseBuilder BuildToilet(int num);

        IHouseBuilder BuildGarden(int num);

        House Build();
    }
}