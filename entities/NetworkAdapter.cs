using System;
using System.Collections.Generic;
using System.Text;

namespace entities
{
    public class NetworkAdapter : Device
    {
        public string NameAdapter { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
        public string NetworkStatus { get; set; }
    }
}
