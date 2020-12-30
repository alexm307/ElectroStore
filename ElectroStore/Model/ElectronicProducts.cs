using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class ElectronicProducts
    {
        [Key]  //automatically calls ID as identity column - creates ID val automatically
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public int Price { get; set; }

        public double Rating { get; set; }

        public int Quantity { get; set; }

        public string Color { get; set; }


        //testing testing 123

    }
}
