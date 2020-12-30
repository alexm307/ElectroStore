using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class Laptops : ElectronicProducts
    {
        public string Brand { get; set; }

        public string RAM { get; set; }

        public int CPU { get; set; }

        public int GPU { get; set; }

        public double Battery { get; set; }

        public string Display { get; set; }

        public int Storage_GB { get; set; }

        public string DisplaySize_inches { get; set; }
    }
}
