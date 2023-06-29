namespace Jellyfin.Jellybench.Server.Shared;

public record JellybenchResult
{
    public IReadOnlyList<JellybenchResultDataPoint> DataPoints { get; set; }

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