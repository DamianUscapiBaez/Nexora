using Entities;

namespace entities
{
    public enum ComputerType { Desktop, Laptop, AllInOne, Unknown }
    public class Computer : Device
    {
        public string? HostName { get; set; }
        public ComputerType ComputerType { get; set; }
        public SystemInfo SystemInfo { get; set; }
        public HardwareInfo Hardware { get; set; }
        public string CurrentUser { get; set; }
    }
}
