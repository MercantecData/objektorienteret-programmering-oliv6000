using System;

namespace ArchiveOverComputerWebshopLibrary
{
    public class Desktop : Computer, IPeripheralMethods
    {
        protected Case computerCase;

        public Desktop(string name, CPU cpu, GPU gpu, Manufacturer manufacturer, DateTime releaseDate, decimal price) : base(name, cpu, gpu, manufacturer, releaseDate, price)
        {
        }

        public override string GetDescription()
        {
            return "Perfect system for gaming and productivity. With a lot of bang for the buck.";
        }

        public string ClickKeyboard()
        {
            return "Clickety Clackety...";
        }

        public int[] MoveMouse(int x, int y)
        {
            return new int[]{x,y};
        }
    }
}