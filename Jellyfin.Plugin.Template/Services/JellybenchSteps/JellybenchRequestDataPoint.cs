namespace Jellyfin.Jellybench.Server.Shared;

public record JellybenchRequestDataPoint
{
    public string Name { get; set; }
    public int ResolutionX { get; set; }
    public int ResolutionY { get; set; }
    public float Framerate { get; set; }
    public int Bitrate { get; set; }
    public string Codec { get; set; }
    public string ExampleDataUrl { get; set; }
}