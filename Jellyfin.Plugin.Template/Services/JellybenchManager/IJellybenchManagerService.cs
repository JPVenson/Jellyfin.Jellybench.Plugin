namespace Jellyfin.Plugin.Template.Services.JellybenchManager;

public interface IJellybenchManagerService
{
    bool HasReport { get; }
    void RunReport();
    string ReadReport();
}
