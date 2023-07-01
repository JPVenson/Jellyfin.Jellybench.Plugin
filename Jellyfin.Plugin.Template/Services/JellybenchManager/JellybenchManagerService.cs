using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jellyfin.Plugin.Template.ScheduledTasks;
using MediaBrowser.Model.Tasks;

namespace Jellyfin.Plugin.Template.Services.JellybenchManager;

/// <inheritdoc/>
public class JellybenchManagerService : IJellybenchManagerService
{
    /// <summary>
    /// The report containing details about the benchmark.
    /// </summary>
    public const string JellybenchReport = "./Jellybench-Report.json";

    private readonly ITaskManager _taskManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="JellybenchManagerService"/> class.
    /// </summary>
    /// <param name="taskManager">task manager service.</param>
    public JellybenchManagerService(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    /// <inheritdoc/>
    public bool HasReport
    {
        get
        {
            return File.Exists(JellybenchReport);
        }
    }

    /// <inheritdoc/>
    public void RunReport()
    {
        _taskManager.Execute<JellybenchTask>();
    }

    /// <inheritdoc/>
    public string ReadReport()
    {
        return File.ReadAllText(JellybenchReport);
    }
}
