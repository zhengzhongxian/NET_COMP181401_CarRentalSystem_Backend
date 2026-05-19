using System.Threading.Channels;
using Microsoft.Extensions.Logging;

namespace NET_CarRentalSystem.Application.Common.Queue;

public class TaskQueue<TRequest, TResult>
{
    private readonly Channel<(TRequest Request, TaskCompletionSource<TResult> Tcs, CancellationToken Ct)> _channel;
    private readonly ILogger _logger;

    public int PendingCount => _channel.Reader.Count;

    public TaskQueue(
        Func<TRequest, CancellationToken, Task<TResult>> processor,
        int maxConcurrent = 5,
        int maxQueue = 1000,
        ILogger? logger = null)
    {
        _logger = logger!;
        _channel = Channel.CreateBounded<(TRequest, TaskCompletionSource<TResult>, CancellationToken)>(
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

                await foreach (var (request, tcs, ct) in _channel.Reader.ReadAllAsync())
                {
                    if (ct.IsCancellationRequested)
                    {
                        _logger?.LogInformation("[TaskQueue] Worker {WorkerId} | Request cancelled before processing", workerId);
                        tcs.TrySetCanceled(ct);
                        continue;
                    }

                    try
                    {
                        _logger?.LogInformation(
                            "[TaskQueue] Worker {WorkerId} | Thread {ThreadId} processing",
                            workerId,
                            Thread.CurrentThread.ManagedThreadId);

                        var result = await processor(request, ct);
                        tcs.TrySetResult(result);
                    }
                    catch (OperationCanceledException ex)
                    {
                        _logger?.LogWarning("[TaskQueue] Worker {WorkerId} | Processing cancelled", workerId);
                        tcs.TrySetCanceled(ex.CancellationToken);
                    }
                    catch (Exception ex)
                    {
                        _logger?.LogError(ex, "[TaskQueue] Worker {WorkerId} error", workerId);
                        tcs.TrySetException(ex);
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

        await using var registration = cancellationToken.Register(() => tcs.TrySetCanceled(cancellationToken));

        await _channel.Writer.WriteAsync((request, tcs, cancellationToken), cancellationToken);

        _logger?.LogInformation("[TaskQueue] Enqueued | Pending: {Count}", PendingCount);

        return await tcs.Task;
    }
}
