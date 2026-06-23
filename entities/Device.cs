using System;
using System.Collections.Generic;
using System.Text;

namespace entities
{
    public abstract class Device
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
    }
}
