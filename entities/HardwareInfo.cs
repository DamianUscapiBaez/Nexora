using System;
using System.Collections.Generic;
using System.Text;

namespace entities
{
    public class HardwareInfo
    {
        public List<Monitor> Monitors { get; set; } 
        public string Cpu { get; set; }
        public string Ram {  get; set; }
        public List<Disk> Disks { get; set; }   
    }
}
