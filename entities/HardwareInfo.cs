using entities;

namespace Entities
{
    public class HardwareInfo
    {
        // CPU
        public string CpuName { get; set; }
        public int CpuCores { get; set; }
        public int CpuThreads { get; set; }
        public double CpuBaseSpeed { get; set; }
        public double CpuMaximumSpeed { get; set; } 

        // RAM
        public double TotalRam { get; set; }
        public string RamType { get; set; }
        public int RamSpeedMhz { get; set; }
        public int RamUsedSlots { get; set; }
        public int RamTotalSlots { get; set; }

        // GPU
        public string GpuName { get; set; }
        public double VramTotalGB { get; set; }
        public string Manufacturer { get; set; } 

        // Disk
        public List<Disk> Disks { get; set; }

        // Monitors
        public List<entities.Monitor> Monitors { get; set; }

        // Network
        public string NetworkAdapter { get; set; }
        public string MacAddress { get; set; } 
        public string IpAddress { get; set; }  
        public string NetworkStatus { get; set; } 

        // Uptime
        public TimeSpan Uptime { get; set; }
    }
}