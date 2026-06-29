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
                OperatingSystem = GetOperatingSystem(),
                OSVersion = GetOSVersion(),
                OSBuild = GetOSBuild(),
                OSArchitecture = GetOSArchitecture(),
                InstalledDate = GetInstallDate()
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
                // Solo necesitamos "CurrentBuild", el UBR no es necesario
                return key?.GetValue("CurrentBuild")?.ToString() ?? "Unknown";
            }
        }

        private static DateOnly GetInstallDate()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
            {
                object installDate = key?.GetValue("InstallDate");
                if (installDate != null)
                {
                    // Convertimos los segundos a DateTime y luego a DateOnly
                    DateTime dt = new DateTime(1970, 1, 1).AddSeconds(Convert.ToDouble(installDate));
                    return DateOnly.FromDateTime(dt);
                }
            }
            return default; // Devuelve 01/01/0001 si no se encuentra
        }
    }
}
