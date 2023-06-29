namespace Jellyfin.Jellybench.Server.Shared;
public record JellybenchRequest
{
    public string RequestKey { get; set; }

    public JellybenchRequestDataPoint[] DataPoints { get; set; }
}