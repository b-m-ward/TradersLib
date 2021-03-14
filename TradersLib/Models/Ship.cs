using System;
using System.Collections.Generic;
using System.Text;

namespace TradersLib.Models
{
    public class Ship
    {
        public string Class { get; set; }
        public string Manufacturer { get; set; }
        public int MaxCargo { get; set; }
        public int Plating { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public int Weapons { get; set; }
        public PurchaseLocation[] PurchaseLocations { get; set; }

    }
}
