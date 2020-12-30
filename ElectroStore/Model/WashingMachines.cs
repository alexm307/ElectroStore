using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class WashingMachines : KitchenAppliances
    {
        public string LoadingType { get; set; }

        public string LoadingCapacity { get; set; }

        public int NoOfPrograms { get; set; }
    }
}
