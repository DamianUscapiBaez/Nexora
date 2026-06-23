using System;
using System.Collections.Generic;
using System.Text;

namespace entities
{
    public class Disk : Device
    {
        public string CapacityGB { get; set; }
        public string InterfaceType { get; set; }
    }
}
