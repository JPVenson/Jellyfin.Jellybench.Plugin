using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellyfin.Plugin.Template.Services.JellybenchSteps
{
    public record JellybenchRequest
    {
        public string RequestKey { get; set; }

        public JellybenchDataPoint[] DataPoints { get; set; }
    }

    public record JellybenchDataPoint
    {
        public string Name { get; set; }
        public int ResolutionX { get; set; }
        public int ResolutionY { get; set; }
        public float Framerate { get; set; }
        public int Bitrate { get; set; }
        public string Codec { get; set; }
        public string ExampleDataUrl { get; set; }
    }

    public record JellybenchDataPointResult
    {
        public string Name { get; set; }
        public float FramerateResult { get; set; }
        public string OutputCodec { get; set; }
        public string ExampleDataUrl { get; set; }
    }

    public record JellybenchResult
    {
        public JellybenchDataPointResult[] DataPoints { get; set; }

        public string CpuName { get; set; }
        public string CpuManufacture { get; set; }
        public string NumberCores { get; set; }
        public string SystemRam { get; set; }

        public string GpuName { get; set; }
        public string GpuManufacture { get; set; }
        public string GpuRam { get; set; }

        public DiscType JellyfinConfigDirectoryDiscType { get; set; }
        public DiscType JellyfinMediaDirectoryDiscType { get; set; }
        public string DataRequestKey { get; set; }
    }

    public enum DiscType
    {
        Hdd,
        Ssd,
        RemoteMount,
        RamDisc
    }
}
