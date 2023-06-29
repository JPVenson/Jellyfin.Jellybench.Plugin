using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBrowser.Model.Tasks;

namespace Jellyfin.Plugin.Template.Services.JellybenchManager;

public class JellybenchManagerService : IJellybenchManagerService
{
    private readonly ITaskManager _taskManager;

    public JellybenchManagerService(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    public const string JellybenchReport = "./Jellybench-Report.json";

    public bool HasReport
    {
        get
        {
            return File.Exists(JellybenchReport);
        }
    }

    public void RunReport()
    {
        _taskManager.Execute<JellybenchTask>();
    }

    public string ReadReport()
    {
        return File.ReadAllText(JellybenchReport);
    }
}
