using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color-{Color}\nBrand{Brand}\nMillage{Millage}");
        }
        public abstract void Drive(double millage);
        
    }
}
