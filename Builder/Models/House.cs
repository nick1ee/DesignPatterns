using System;

namespace Builder.Models
{
    public class House
    {
        public int roomCount;

        public int windowCount;

        public int toiletCount;

        public int gardenCount;

        public void Display()
        {
            Console.WriteLine($"This is a house with {roomCount} roomes, {windowCount} windows, {toiletCount} toilets and {gardenCount} garden.");
        }
    }
}