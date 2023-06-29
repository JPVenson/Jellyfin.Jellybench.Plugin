namespace Jellyfin.Plugin.Template.Services.JellybenchManager;

/// <summary>
/// Benchmark service interface.
/// </summary>
public interface IJellybenchManagerService
{
    /// <summary>
    /// Gets a value indicating whether has report.
    /// </summary>
    bool HasReport { get; }

    /// <summary>
    /// Run the report.
    /// </summary>
    void RunReport();

    /// <summary>
    /// Read the report.
    /// </summary>
    /// <returns>report details.</returns>
    string ReadReport();
}
