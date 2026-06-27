using System;
using System.Collections.Generic;
using System.Text;

namespace entities
{
    public class HardwareInfo
    {
        // CPU
        public string Cpu { get; set; }
        public int CpuCores { get; set; }
        public int CpuThreads { get; set; }
        public double CpuUsage { get; set; }
        public double CpuTemperature { get; set; }

        //Ram
        public double Ram { get; set; }
        public double RamUsedGB { get; set; }
        public double RamAvailableGB { get; set; }
        public double RamUsagePercent { get; set; }

        // GPU
        public string Gpu { get; set; }
        public double GpuUsage { get; set; }
        public double GpuTemperature { get; set; }
        public double VramUedsGB { get; set; }
        public double VramTotalGB { get; set; }

        // Disk
        public string TotalGBDisk { get; set; }
        public string UsedGBDisk { get; set; }
        public string FreeGBDisk { get; set; }
        public List<Disk> Disks { get; set; }

        // Monitors
        public List<Monitor> Monitors { get; set; }

        // Red
        public string NetworkAdapter { get; set; }
        public double DownloadMbps { get; set; }
        public double UploadMbps { get; set; }

        // Tiempo activo
        public TimeSpan Uptime { get; set; }
    }
}
