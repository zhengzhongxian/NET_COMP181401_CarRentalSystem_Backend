using System.Threading.Channels;
using Microsoft.Extensions.Logging;

namespace NET_CarRentalSystem.Application.Common.Queue;

public class TaskQueue<TRequest, TResult>
{
    private readonly Channel<(TRequest Request, TaskCompletionSource<TResult> Tcs)> _channel;
    private readonly ILogger _logger;

    public int PendingCount => _channel.Reader.Count;

    public TaskQueue(
        Func<TRequest, CancellationToken, Task<TResult>> processor,
        int maxConcurrent = 5,
        int maxQueue = 1000,
        ILogger? logger = null)
    {
        _logger = logger!;
        _channel = Channel.CreateBounded<(TRequest, TaskCompletionSource<TResult>)>(
            new BoundedChannelOptions(maxQueue)
            {
                FullMode = BoundedChannelFullMode.Wait,
                SingleReader = false,
                SingleWriter = false
            });

        StartWorkers(processor, maxConcurrent);
    }

    private void StartWorkers(
        Func<TRequest, CancellationToken, Task<TResult>> processor,
        int workerCount)
    {
        for (int i = 0; i < workerCount; i++)
        {
            int workerId = i;
            _ = Task.Run(async () =>
            {
                _logger?.LogInformation("[TaskQueue] Worker {WorkerId} started", workerId);

                await foreach (var (request, tcs) in _channel.Reader.ReadAllAsync())
                {
                    try
                    {
                        _logger?.LogInformation(
                            "[TaskQueue] Worker {WorkerId} | Thread {ThreadId} processing",
                            workerId,
                            Thread.CurrentThread.ManagedThreadId);

                        var result = await processor(request, CancellationToken.None);
                        tcs.SetResult(result);
                    }
                    catch (Exception ex)
                    {
                        _logger?.LogError(ex, "[TaskQueue] Worker {WorkerId} error", workerId);
                        tcs.SetException(ex);
                    }
                }
            });
        }
    }

    public async Task<TResult> EnqueueAsync(
        TRequest request,
        CancellationToken cancellationToken = default)
    {
        var tcs = new TaskCompletionSource<TResult>(
            TaskCreationOptions.RunContinuationsAsynchronously);

        await _channel.Writer.WriteAsync((request, tcs), cancellationToken);

        _logger?.LogInformation("[TaskQueue] Enqueued | Pending: {Count}", PendingCount);

        return await tcs.Task;
    }
}
