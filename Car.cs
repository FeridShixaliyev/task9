using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class Car: Vehicle
    {
        public int FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;

        public override void Drive(double millage)
        {
            if (millage * FuelFor1km <= CurrentFuel)
            {
                Console.WriteLine("Yeteri qeder benzin var");
                CurrentFuel = CurrentFuel - millage * FuelFor1km;
                Millage = Millage + millage;
                Console.WriteLine($"Gedilecek yol sonrasi benzin:{CurrentFuel}");

            }
            else 
            {
                Console.WriteLine("Yeteri qeder benzin yoxdur!!");
            }
        }

    }
}
