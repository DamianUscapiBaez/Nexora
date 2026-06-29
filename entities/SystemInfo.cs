namespace entities
{
    public class SystemInfo
    {
        public string OperatingSystem { get; set; }
        public string OSVersion { get; set; }
        public string OSBuild { get; set; }
        public string OSArchitecture { get; set; }
        public DateOnly InstalledDate { get; set; }
    }
}
