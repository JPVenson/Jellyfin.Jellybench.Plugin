namespace Jellyfin.Jellybench.Server.Shared;

public record JellybenchResultDataPoint
{
    public string Name { get; set; }
    public int NumberOfStreams { get; set; }
}