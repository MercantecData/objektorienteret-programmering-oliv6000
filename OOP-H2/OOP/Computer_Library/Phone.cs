using System;

namespace ArchiveOverComputerWebshopLibrary
{
    public class Phone : ComputerWithScreen
    {
        public Phone(string name, CPU cpu, GPU gpu, Manufacturer manufacturer, DateTime releaseDate, decimal price, int resolutionWidtht, int resolutionHeight, int responseMs) : base(name, cpu, gpu, manufacturer, releaseDate, price, resolutionWidtht, resolutionHeight, responseMs)
        {
        }

        public override string GetDescription()
        {
            return "Portable mini computer with a smart and touchable intuitive OS";
        }
    }
}