using System;

namespace ArchiveOverComputerWebshopLibrary
{
    public abstract class ComputerWithScreen : Computer
    {
        protected float sizeInches;
        protected int resolutionWidth;
        protected int resolutionHeight;
        protected int responseMs;
        protected ScreenType screenType;

        protected ComputerWithScreen(string name, CPU cpu, GPU gpu, Manufacturer manufacturer, DateTime releaseDate,
            decimal price, int resolutionWidtht, int resolutionHeight, int responseMs) : base(name, cpu, gpu, manufacturer, releaseDate, price)
        {
            this.resolutionHeight = resolutionHeight;
            this.resolutionWidth = resolutionWidtht;
            this.responseMs = responseMs;
        }

        public override string GetSalesFeatures()
        {
            return base.GetSalesFeatures() + " It also has a screen!";
        }
    }
}