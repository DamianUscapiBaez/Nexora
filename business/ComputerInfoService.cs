using Business;
using entities;
using System.Management;

namespace business
{
    public class ComputerInfoService
    {

        public static Computer GetComputerInfo()
        {
            var computer = new Computer
            {
                SerialNumber = GetSerialNumber(),
                Manufacturer = GetManufacturer(),
                Model = GetModel(),
                ComputerType = GetDeviceType(),
                Hardware = HardwareInfoService.GetHardwareInfo(),
                OperatingSystem = SystemInfoService.GetOperatingSystemInfo()
            };

            return computer;
        }

        private static string GetManufacturer()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["Manufacturer"]?.ToString() ?? "Unknown";
                }
            }
            return "Unknown";
        }

        private static string GetSerialNumber()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["SerialNumber"]?.ToString() ?? "Unknown";
                }
            }
            return "Unknown";
        }

        private static string GetModel()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT Version FROM Win32_ComputerSystemProduct"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["Version"]?.ToString() ?? "Unknown";
                }
            }

            return "Unknown";
        }

        private static ComputerType GetDeviceType()
        {
            using (var searcher = new ManagementObjectSearcher(
                "SELECT ChassisTypes FROM Win32_SystemEnclosure"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (!(obj["ChassisTypes"] is ushort[] types))
                        continue;

                    if (types.Contains((ushort)13))
                        return ComputerType.AllInOne;

                    if (types.Any(t => t == 9 || t == 10 || t == 14))
                        return ComputerType.Laptop;

                    if (types.Any(t => t == 3 || t == 4 || t == 5 ||
                                       t == 6 || t == 7))
                        return ComputerType.Desktop;
                }
            }

            return ComputerType.Unknown;
        }
    }
}
