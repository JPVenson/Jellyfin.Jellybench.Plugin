namespace Jellyfin.Jellybench.Server.Shared;

/// <summary>
/// Jelly benchmark request record.
/// </summary>
public record JellybenchRequest
{
    /// <summary>
    /// Gets or sets request key.
    /// </summary>
    public string? RequestKey { get; set; }

    /// <summary>
    /// Gets or sets data points.
    /// </summary>
#pragma warning disable CA1819
    public JellybenchRequestDataPoint[]? DataPoints { get; set; }
#pragma warning restore CA1819
}