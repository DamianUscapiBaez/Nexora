using System;
using System.Collections.Generic;
using System.Text;

namespace entities
{
    public class Monitor : Device
    {
        public bool IsInternal { get; set; }
        public string Resolution { get; set; }
        public int RefreshRate { get; set; }
        public double SizeInches { get; set; }
        public string ManufactureDate { get; set; }
        public bool IsConnected { get; set; }
    }
}
