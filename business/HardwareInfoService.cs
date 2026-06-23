using entities;
using System.Management;
using System.Text;

namespace business
{
    public static class HardwareInfoService
    {
        public static HardwareInfo GetHardwareInfo()
        {
            var hardwareInfo = new HardwareInfo
            {
                Cpu = GetCpu(),
                Ram = GetRam(),
                Disks = GetDisks(),
                Monitors = GetMonitors()
            };

            return hardwareInfo;
        }

        private static string GetCpu()
        {
            using (var search = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in search.Get())
                    return obj["Name"]?.ToString();

                return "Unknown";
            }
        }

        private static string GetRam()
        {
            using (var search = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory"))
            {
                long totalCapacity = 0;
                foreach (ManagementObject obj in search.Get())
                {
                    if (long.TryParse(obj["Capacity"]?.ToString(), out long capacity))
                        totalCapacity += capacity;
                }
                return $"{totalCapacity / (1024 * 1024 * 1024)} GB";
            }
        }
        private static List<Disk> GetDisks()
        {
            var disks = new List<Disk>();
            using (var search = new ManagementObjectSearcher("SELECT Model, Size FROM Win32_DiskDrive"))
            {
                foreach (ManagementObject obj in search.Get())
                {
                    string model = obj["Model"]?.ToString() ?? "Unknown";
                    string size = obj["Size"] != null && long.TryParse(obj["Size"].ToString(), out long sizeBytes)
                        ? $"{sizeBytes / (1024 * 1024 * 1024)} GB"
                        : "Unknown";
                    disks.Add(new Disk { Model = model, CapacityGB = size });
                }
            }
            return disks;
        }
        private static List<entities.Monitor> GetMonitors()
        {
            var monitors = new List<entities.Monitor>();

            var scope = new ManagementScope(@"\\.\root\wmi");

            using (var searcher = new ManagementObjectSearcher(scope, new ObjectQuery("SELECT * FROM WmiMonitorID")))
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

            return monitors;
        }
        private static string DecodeWmiString(ushort[] data)
        {
            if (data == null)
                return "Unknown";

            StringBuilder sb = new StringBuilder();

            foreach (ushort c in data)
            {
                if (c == 0)
                    break;

                sb.Append((char)c);
            }

            return sb.ToString();
        }
    }
}
