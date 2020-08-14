using System;
using ArchiveOverComputerWebshopLibrary;

namespace ArchiveOverComputerWebshopConsole
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Computer phone = new Phone("Iphone 6", CPU.Snapdragon855, GPU.RXT2080mobile, Manufacturer.APPLE, DateTime.Today, 6500.00m, 450, 960, 5);
            Computer desktop = new Desktop("GAMING DESKTOP", CPU.IntelCoreI76700k, GPU.RXT2080, Manufacturer.APPLE, DateTime.Today, 100.00m);
            Computer laptop = new Laptop("Lenovo thinkpad", CPU.AMDRyzen73700X, GPU.GTX1070TI, Manufacturer.LENOVO, DateTime.Today, 299.00m, 1920,1080,1);
            Console.WriteLine(phone.GetSalesFeatures() + "\n");
            Console.WriteLine(desktop.GetSalesFeatures() + "\n");
            Console.WriteLine(desktop.GetDescription() + "\n");
            Console.WriteLine($"Desktop - {desktop.GetSalesFeatures()} - this is why you should buy it");
        }
    }
}