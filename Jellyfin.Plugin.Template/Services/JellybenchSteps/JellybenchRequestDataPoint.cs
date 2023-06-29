namespace Jellyfin.Jellybench.Server.Shared;

/// <summary>
/// Data point of Jellybench.
/// </summary>
public record JellybenchRequestDataPoint
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the horizontal resolution.
    /// </summary>
    public int? ResolutionX { get; set; }

    /// <summary>
    /// Gets or sets the vertical resolution.
    /// </summary>
    public int? ResolutionY { get; set; }

    /// <summary>
    /// Gets or sets the framerate.
    /// </summary>
    public float? Framerate { get; set; }

    /// <summary>
    /// Gets or sets the bitrate.
    /// </summary>
    public int? Bitrate { get; set; }

    /// <summary>
    /// Gets or sets the codec.
    /// </summary>
    public string? Codec { get; set; }

    /// <summary>
    /// Gets or sets the data url.
    /// </summary>
    public string? ExampleDataUrl { get; set; }
}