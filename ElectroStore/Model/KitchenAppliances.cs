using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class KitchenAppliances : ElectronicProducts
    {
        public int AnnualEnergyConsumption_kWh { get; set; }

        public string EuEnergyLabel { get; set; }

        public string SoundLevels { get; set; }
    }
}