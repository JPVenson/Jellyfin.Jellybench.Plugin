using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Model.Tasks;

namespace Jellyfin.Plugin.Template.Services.JellybenchManager;

/// <inheritdoc/>
public class JellybenchTask : IScheduledTask
{
    /// <inheritdoc/>
    public string Name => "JellyBench";

    /// <inheritdoc/>
    public string Key => "JellyBench";

    /// <inheritdoc/>
    public string Description => "Transcoding benchmark tool.";

    /// <inheritdoc/>
    public string Category => "Benchmark";

    /// <summary>
    /// Runs the Scheduled task to evaluate the current capabilities of the system.
    /// </summary>
    /// <param name="progress">The progress handler.</param>
    /// <param name="cancellationToken">The stop Token.</param>
    /// <returns>A task. Duh.</returns>
    public async Task ExecuteAsync(IProgress<double> progress, CancellationToken cancellationToken)
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://jellybench.jpb.pizza");
        var httpResponseMessage = await httpClient.GetAsync($"/api/jellybench/PrepareDataPoints", cancellationToken).ConfigureAwait(false);
        var dataRequest = await httpResponseMessage.Content.ReadFromJsonAsync<JellybenchRequest>((JsonSerializerOptions?)null, cancellationToken).ConfigureAwait(false)!;

        var result = new List<JellybenchResultDataPoint>();
        for (var index = 0; index < dataRequest.DataPoints.Length; index++)
        {
            var jellybenchDataPoint = dataRequest.DataPoints[index];
            progress.Report(dataRequest.DataPoints.Length / 100D * index / 100D);
            // TODO obtain jellybench.ExampleDataUrl or load from cache
            // TODO invoke ffmpeg and load result into JellybenchDataPointResult
            // TODO add as many parallel ffmpeg tasks every 10 sec as long as the individial framerate stays over 24fps
        }

        var jellyfinResult = new JellybenchResult();
        // TODO fill result properties
        jellyfinResult.DataPoints = result.ToArray();
        jellyfinResult.DataRequestKey = dataRequest.RequestKey;
        await httpClient.PostAsJsonAsync("/api/jellybench/Results", jellyfinResult, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public IEnumerable<TaskTriggerInfo> GetDefaultTriggers()
    {
        return new[] { new TaskTriggerInfo() { Type = "OnDemand" } };
    }
}
