using System;
using System.Collections.Generic;
using System.Text;

namespace entities
{
    public enum ComputerType { Desktop, Laptop, AllInOne, Unknown }
    public class Computer : Device
    {
        public ComputerType ComputerType { get; set; }
        public SystemInfo OperatingSystem { get; set; }
        public HardwareInfo Hardware { get; set; }
    }
}
