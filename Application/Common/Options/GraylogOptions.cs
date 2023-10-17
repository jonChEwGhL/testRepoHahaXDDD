using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Options
{
    public class GraylogOptions
    {
        public const string Graylog = "Graylog";

        public string? HostName { get; set; }
        public int? Port { get; set; }
        public string? LogPath { get; set; }
        public string? FileFormat { get; set; }
    }
}
