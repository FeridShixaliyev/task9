using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class Bycle:Vehicle
    {
        public override void Drive(double millage)
        {
            Millage = Millage + millage;
        }
    }
}
