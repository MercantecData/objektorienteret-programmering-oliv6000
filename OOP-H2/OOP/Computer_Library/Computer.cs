using System;
using System.Collections.Generic;

namespace ArchiveOverComputerWebshopLibrary
{
    public abstract class Computer: ISale
    {
        protected string name;
        protected CPU cpu;
        protected GPU gpu;
        protected Manufacturer manufacturer;
        protected DateTime releaseDate;
        protected decimal price;

        protected Computer(string name, CPU cpu, GPU gpu, Manufacturer manufacturer, DateTime releaseDate, decimal price)
        {
            this.name = name;
            this.cpu = cpu;
            this.gpu = gpu;
            this.manufacturer = manufacturer;
            this.releaseDate = releaseDate;
            this.price = price;
        }

        public virtual string GetSalesFeatures()
        {
            return $"This is a very good device made by {manufacturer}. It has an {cpu} CPU and an {gpu} GPU.";
        }

        public abstract string GetDescription();
        
        public List<string> TargetAudience()
        {
            List<String> clients = new List<string>();
            clients.Add("Gamers");
            clients.Add("Office Workers");
            return clients;
        }
    }
}