using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Dealer
    {
        public float Price { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public List<Car> Cars { get; set; }
        public string Name { get; set; }
        public string location { get; set; }


    }
}
