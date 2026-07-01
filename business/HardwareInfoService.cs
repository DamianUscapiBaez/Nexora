using entities;
using Entities; // Corregido a PascalCase (Entities)
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text;
using System.Threading;

namespace Business
{
    public static class HardwareInfoService
    {
        private static DateTime? _lastBootUpTime = null;

        public static HardwareInfo GetHardwareInfo()
        {
            var ramInfo = GetRamInfo();

            // 1. Obtenemos primero la lista física mapeada
            var diskList = GetDisks();

            return new HardwareInfo
            {
                // CPU - Mapeado a las propiedades de tu nueva entidad
                CpuName = GetCpu(),
                CpuCores = GetCpuCoresAndThreads().Cores,
                CpuThreads = GetCpuCoresAndThreads().Threads,
                CpuBaseSpeed = GetCpuSpeed("CurrentClockSpeed"), 
                CpuMaximumSpeed = GetCpuSpeed("MaxClockSpeed"),

                // RAM
                TotalRam = ramInfo.TotalRam,
                RamType = ramInfo.RamType,
                RamSpeedMhz = ramInfo.RamSpeedMhz,
                RamUsedSlots = GetRamSlotsInfo().used,
                RamTotalSlots = GetRamSlotsInfo().total,

                // GPU
                GpuName = GetGpu(),
                VramTotalGB = GetVramTotalGb(),
                Manufacturer = GetGpuManufacturer(), // Mapeado a Manufacturer

                // Disks
                Disks = diskList,

                // Monitors
                Monitors = GetMonitors(),

                // Network (Campos agregados en tu entidad que faltaban mapear aquí)
                NetworkAdapter = "Unknown",
                MacAddress = "Unknown",
                IpAddress = "Unknown",
                NetworkStatus = "Unknown",

                // Uptime
                Uptime = GetUptimeRealTime()
            };
        }
        // CPU
        private static string GetCpu()
        {
            using (var search = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in search.Get())
                {
                    string name = obj["Name"]?.ToString().Trim() ?? "Unknown";

                    // Elimina la frecuencia (@...), etiquetas (R)/(TM) y palabras redundantes como "CPU"
                    return System.Text.RegularExpressions.Regex.Replace(name, @"\s?@.*|\(R\)|\(TM\)|CPU", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Trim();
                }
            }
            return "Unknown";
        }

        private static (int Cores, int Threads) GetCpuCoresAndThreads()
        {
            int cores = 0;
            int threads = 0;
            using (var search = new ManagementObjectSearcher("SELECT NumberOfCores, NumberOfLogicalProcessors FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in search.Get())
                {
                    cores += obj["NumberOfCores"] != null ? Convert.ToInt32(obj["NumberOfCores"]) : 0;
                    threads += obj["NumberOfLogicalProcessors"] != null ? Convert.ToInt32(obj["NumberOfLogicalProcessors"]) : 0;
                }
            }
            return (cores, threads);
        }

        private static double GetCpuSpeed(string propertyName)
        {
            // propertyName puede ser "MaxClockSpeed" o "CurrentClockSpeed"
            using (var search = new ManagementObjectSearcher($"SELECT {propertyName} FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in search.Get())
                {
                    if (obj[propertyName] != null)
                    {
                        return Math.Round(Convert.ToDouble(obj[propertyName]) / 1000.0, 2);
                    }
                }
            }
            return 0.0;
        }
        // RAM
        private static HardwareInfo GetRamInfo()
        {
            var ram = new HardwareInfo();
            double totalInstalledGB = 0;

            using (var searcher = new ManagementObjectSearcher("SELECT Capacity, SMBIOSMemoryType, MemoryType, ConfiguredClockSpeed, Speed FROM Win32_PhysicalMemory"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["Capacity"] != null)
                    {
                        totalInstalledGB += Convert.ToDouble(obj["Capacity"]) / 1024 / 1024 / 1024;
                    }

                    if (string.IsNullOrEmpty(ram.RamType))
                    {
                        ushort tipo = obj["SMBIOSMemoryType"] != null ? Convert.ToUInt16(obj["SMBIOSMemoryType"]) : Convert.ToUInt16(obj["MemoryType"]);
                        ram.RamType = GetRamType(tipo); // Renombrado a inglés
                        ram.RamSpeedMhz = obj["ConfiguredClockSpeed"] != null ? Convert.ToInt32(obj["ConfiguredClockSpeed"]) : Convert.ToInt32(obj["Speed"]);
                    }
                }
            }

            ram.TotalRam = Math.Round(totalInstalledGB, 2);
            return ram;
        }

        private static (int used, int total) GetRamSlotsInfo()
        {
            int usedSlots = 0;
            int totalSlots = 0;

            // 1. Obtener los slots usados (módulos conectados)
            using (var searcher = new ManagementObjectSearcher("SELECT DeviceLocator FROM Win32_PhysicalMemory"))
            {
                usedSlots = searcher.Get().Count;
            }

            // 2. Obtener el total de slots de la placa base
            using (var searcher = new ManagementObjectSearcher("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["MemoryDevices"] != null)
                    {
                        totalSlots += Convert.ToInt32(obj["MemoryDevices"]);
                    }
                }
            }

            return (usedSlots, totalSlots);
        }
        // GPU
        private static string GetGpu()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["Name"]?.ToString() ?? "Unknown";
                }
                return "Unknown";
            }
        }

        private static string GetGpuManufacturer()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT AdapterCompatibility FROM Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["AdapterCompatibility"]?.ToString() ?? "Unknown";
                }
                return "Unknown";
            }
        }

        private static double GetVramTotalGb()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT AdapterRAM FROM Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["AdapterRAM"] != null)
                    {
                        long bytes = Convert.ToInt64(obj["AdapterRAM"]);
                        return Math.Round(bytes / 1024.0 / 1024.0 / 1024.0, 2);
                    }
                }
                return 0;
            }
        }

        public static List<Disk> GetDisks()
        {
            List<Disk> disks = new List<Disk>();

            try
            {
                using (ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(
                        "SELECT Model, Size, SerialNumber, InterfaceType FROM Win32_DiskDrive"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        string model = obj["Model"]?.ToString()?.Trim() ?? "Desconocido";
                        string serial = obj["SerialNumber"]?.ToString()?.Trim() ?? "No disponible";
                        string interfaceType = obj["InterfaceType"]?.ToString()?.Trim() ?? "";

                        long sizeBytes = obj["Size"] != null
                            ? Convert.ToInt64(obj["Size"])
                            : 0;

                        double sizeGb = sizeBytes / (1024.0 * 1024.0 * 1024.0);
                        string capacity = FormatStorageSize(sizeGb);

                        string mediaType = "HDD";

                        string upperModel = model.ToUpper();

                        if (upperModel.Contains("NVME"))
                            mediaType = "NVMe";
                        else if (upperModel.Contains("SSD"))
                            mediaType = "SSD";
                        else if (interfaceType.Equals("NVMe", StringComparison.OrdinalIgnoreCase))
                            mediaType = "NVMe";
                        else if (interfaceType.Equals("SCSI", StringComparison.OrdinalIgnoreCase))
                            mediaType = "SSD"; // Muchos SSD modernos aparecen como SCSI

                        disks.Add(new Disk
                        {
                            Model = model,
                            SerialNumber = serial,
                            CapacityGB = capacity,
                            InterfaceType = interfaceType,
                            MediaType = mediaType
                        });
                    }
                }
            }
            catch
            {
                return new List<Disk>();
            }

            return disks;
        }

        private static List<Disk> GetDisksFallback()
        {
            var disks = new List<Disk>();
            using (var search = new ManagementObjectSearcher("SELECT Model, Size, InterfaceType FROM Win32_DiskDrive"))
            {
                foreach (ManagementObject obj in search.Get())
                {
                    string model = obj["Model"]?.ToString() ?? "Unknown";
                    long sizeBytes = obj["Size"] != null && long.TryParse(obj["Size"].ToString(), out long b) ? b : 0;
                    double sizeGb = sizeBytes / (1024.0 * 1024.0 * 1024.0);

                    string mediaType = "HDD";
                    string interfaceType = obj["InterfaceType"]?.ToString() ?? "";

                    if (interfaceType.ToUpper().Contains("SCSI") || model.ToUpper().Contains("NVME"))
                        mediaType = "NVMe";
                    else if (model.ToUpper().Contains("SSD"))
                        mediaType = "SSD";

                    disks.Add(new Disk
                    {
                        Model = model,
                        CapacityGB = FormatStorageSize(sizeGb),
                        MediaType = mediaType
                    });
                }
            }
            return disks;
        }

        public static string FormatStorageSize(double gigabytes)
        {
            if (gigabytes >= 1024)
            {
                return $"{Math.Round(gigabytes / 1024.0, 1)} TB";
            }
            return $"{Math.Round(gigabytes, 0)} GB";
        }

        private static List<entities.Monitor> GetMonitors()
        {
            var monitors = new List<entities.Monitor>();
            var scope = new ManagementScope(@"\\.\root\wmi");

            using (var searcher = new ManagementObjectSearcher(scope, new ObjectQuery("SELECT * FROM WmiMonitorID")))
            {
                try
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        monitors.Add(new entities.Monitor
                        {
                            Manufacturer = DecodeWmiString(obj["ManufacturerName"] as ushort[]),
                            Model = DecodeWmiString(obj["UserFriendlyName"] as ushort[]),
                            SerialNumber = DecodeWmiString(obj["SerialNumberID"] as ushort[])
                        });
                    }
                }
                catch (ManagementException)
                {
                }
            }

            return monitors;
        }

        private static string DecodeWmiString(ushort[] data)
        {
            if (data == null) return "Unknown";

            var sb = new StringBuilder();
            foreach (ushort c in data)
            {
                if (c == 0) break;
                sb.Append((char)c);
            }
            return sb.ToString().Trim();
        }

        private static string GetRamType(ushort tipo)
        {
            switch (tipo)
            {
                case 20: return "DDR";
                case 21: return "DDR2";
                case 24: return "DDR3";
                case 26: return "DDR4";
                case 34: return "DDR5";
                default: return "Unknown"; // Traducido Desconocido -> Unknown
            }
        }

        private static TimeSpan GetUptimeRealTime()
        {
            if (!_lastBootUpTime.HasValue)
            {
                using (var searcher = new ManagementObjectSearcher("SELECT LastBootUpTime FROM Win32_OperatingSystem"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        if (obj["LastBootUpTime"] != null)
                        {
                            _lastBootUpTime = ManagementDateTimeConverter.ToDateTime(obj["LastBootUpTime"].ToString());
                            break;
                        }
                    }
                }
            }

            if (_lastBootUpTime.HasValue)
            {
                return DateTime.Now - _lastBootUpTime.Value;
            }

            return TimeSpan.Zero;
        }
    }
}