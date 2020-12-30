using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class GamingLaptops : Laptops
    {
        public int RefreshRate_Hz { get; set; }

        public int ResponseTime_ms { get; set; }
    }
}
