namespace Jellyfin.Jellybench.Server.Shared;

/// <summary>
/// Storage type.
/// </summary>
public enum StorageType
{
    /// <summary>
    /// Hard Drive.
    /// </summary>
    HDD,

    /// <summary>
    /// Solid State Drive.
    /// </summary>
    SSD,

    /// <summary>
    /// Storage accessed over the network.
    /// </summary>
    RemoteMount,

    /// <summary>
    /// Storage in system memory.
    /// </summary>
    RamDisk
}
