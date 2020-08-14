using System;

namespace ArchiveOverComputerWebshopLibrary
{
    public class Laptop : ComputerWithScreen, IPeripheralMethods
    {
        public Laptop(string name, CPU cpu, GPU gpu, Manufacturer manufacturer, DateTime releaseDate, decimal price, int resolutionWidtht, int resolutionHeight, int responseMs) : base(name, cpu, gpu, manufacturer, releaseDate, price, resolutionWidtht, resolutionHeight, responseMs)
        {
        }

        public override string GetDescription()
        {
            return "Just like the powerful work horse, the 'Desktop', but this time, PORTABLE, with a build in monitor.";
        }

        public string ClickKeyboard()
        {
            return "click click click...";
        }
        
        //Clamp mouse movement as laptop has fixed monitor
        public int[] MoveMouse(int x, int y)
        {
            x = Math.Clamp(x, 0, resolutionWidth);
            y = Math.Clamp(y, 0, resolutionHeight);
            return new int[]{x,y};
        }
    }
}