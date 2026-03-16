using Grpc.Core;
using Grpc.Net.Client;
using NET_CarRentalSystem.Infrastructure.Configurations;

namespace NET_CarRentalSystem.Infrastructure.Grpc;

/// <summary>
/// Static factory for creating gRPC channels and setting up clients.
/// </summary>
public static class GrpcChannelFactory
{
    private static GrpcServicesSettings? _settings;
    private static readonly Dictionary<string, GrpcChannel> Channels = new();
    private static readonly object Lock = new();
    
    public static void Settings(GrpcServicesSettings settings)
    {
        _settings = settings;
    }
    
    public static TClient SetChannel<TClient>(this TClient client, string address) where TClient : ClientBase<TClient>
    {
        if (_settings == null)
            throw new InvalidOperationException("GrpcChannelFactory.Settings() must be called first");

        var channel = GetOrCreateChannel(address);
        return (TClient)Activator.CreateInstance(typeof(TClient), channel)!;
    }

    private static GrpcChannel GetOrCreateChannel(string address)
    {
        lock (Lock)
        {
            if (Channels.TryGetValue(address, out var existingChannel))
            {
                return existingChannel;
            }

            var maxMessageSize = _settings!.MaxMessageSizeMb * 1024 * 1024;
            var channel = GrpcChannel.ForAddress(address, new GrpcChannelOptions
            {
                MaxReceiveMessageSize = maxMessageSize,
                MaxSendMessageSize = maxMessageSize
            });

            Channels[address] = channel;
            return channel;
        }
    }
}
