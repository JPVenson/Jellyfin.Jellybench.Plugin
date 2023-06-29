namespace Jellyfin.Jellybench.Server.Shared;

/// <summary>
/// Data point of the benchmark result.
/// </summary>
public record JellybenchResultDataPoint
{
    /// <summary>
    /// Gets or sets name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets number of simultaneous streams.
    /// </summary>
    public int NumberOfStreams { get; set; }
}
