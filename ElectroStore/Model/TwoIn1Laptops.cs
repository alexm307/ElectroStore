using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class TwoIn1Laptops : Laptops
    {
        public string Touchscreen { get; set; }

        public int NumberOfScreens { get; set; }
    }
}
