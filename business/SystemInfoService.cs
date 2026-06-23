using entities;
using Microsoft.Win32;
using System.Management;

namespace business
{
    public class SystemInfoService
    {
        public static SystemInfo GetOperatingSystemInfo()
        {
            var osInfo = new SystemInfo
            {
                HostName = Environment.MachineName,
                OperatingSystem = GetOperatingSystem(),
                OSVersion = GetOSVersion(),
                OSBuild = GetOSBuild(),
                OSArchitecture = GetOSArchitecture(),
            };

            return osInfo;
        }

        private static string GetOperatingSystem()
        {
            using (var search = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem"))
            {
                foreach (ManagementObject obj in search.Get())
                    return obj["Caption"]?.ToString()?.Trim() ?? "Unknown";
            }
            return "Unknown";
        }

        private static string GetOSArchitecture()
        {
            using (var search = new ManagementObjectSearcher("SELECT OSArchitecture FROM Win32_OperatingSystem"))
            {
                foreach (ManagementObject obj in search.Get())
                    return obj["OSArchitecture"]?.ToString() ?? "Unknown";
            }
            return "Unknown";
        }

        private static string GetOSVersion()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
            {
                if (key != null)
                {
                    return key.GetValue("DisplayVersion")?.ToString() ?? "Unknown";
                }
            }
            return "Unknown";
        }

        private static string GetOSBuild()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
            {
                if (key != null)
                {
                    string build = key.GetValue("CurrentBuild")?.ToString() ?? "0";
                    string ubr = key.GetValue("UBR")?.ToString() ?? "0";
                    return $"{build}.{ubr}";
                }
            }
            return "Unknown";
        }
    }
}
