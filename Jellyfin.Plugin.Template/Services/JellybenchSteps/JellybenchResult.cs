namespace Jellyfin.Jellybench.Server.Shared;

/// <summary>
/// Record of benchmark result.
/// </summary>
public record JellybenchResult
{
    /// <summary>
    /// Gets or sets data points.
    /// </summary>
#pragma warning disable CA1819
    public JellybenchResultDataPoint[]? DataPoints { get; set; }
#pragma warning restore CA1819
    /// <summary>
    /// Gets or sets cpu name.
    /// </summary>
    public string? CpuName { get; set; }

    /// <summary>
    /// Gets or sets cpu manufacturer.
    /// </summary>
    public string? CpuManufacturer { get; set; }

    /// <summary>
    /// Gets or sets core count.
    /// </summary>
    public string? NumberCores { get; set; }

    /// <summary>
    /// Gets or sets system memory.
    /// </summary>
    public string? SystemMemory { get; set; }

    /// <summary>
    /// Gets or sets GPU name.
    /// </summary>
    public string? GpuName { get; set; }

    /// <summary>
    /// Gets or sets GPU manufacturer.
    /// </summary>
    public string? GpuManufacturer { get; set; }

    /// <summary>
    /// Gets or sets GPU memory.
    /// </summary>
    public string? GpuMemory { get; set; }

    /// <summary>
    /// Gets or sets jellyfin config directory storage type.
    /// </summary>
    public StorageType JellyfinConfigDirectoryStorageType { get; set; }

    /// <summary>
    /// Gets or sets jellyfin media directory storage type.
    /// </summary>
    public StorageType JellyfinMediaDirectoryStorageType { get; set; }

    /// <summary>
    /// Gets or sets data request key.
    /// </summary>
    public string? DataRequestKey { get; set; }
}
