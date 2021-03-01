using Builder.Models;

namespace Builder
{
    public class HouseBuilder : IHouseBuilder
    {
        private int _roomCount;

        private int _windowCount;

        private int _toiletCount;

        private int _gardenCount;

        public IHouseBuilder BuildRoom(int num)
        {
            this._roomCount = num;
            return this;
        }

        public IHouseBuilder BuildWindow(int num)
        {
            this._windowCount = num;
            return this;
        }

        public IHouseBuilder BuildToilet(int num)
        {
            this._toiletCount = num;
            return this;
        }

        public IHouseBuilder BuildGarden(int num)
        {
            this._gardenCount = num;
            return this;
        }

        public House Build()
        {
            var house = new House();
            house.gardenCount = this._gardenCount;
            house.windowCount = this._windowCount;
            house.toiletCount = this._toiletCount;
            house.roomCount = this._roomCount;

            return house;
        }
    }
}