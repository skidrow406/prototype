using RabbitMQ.Client;
using System;
using Confluent.Kafka;

namespace Microsoft.eShopOnContainers.BuildingBlocks.EventBusKafka
{
    public interface IKafkaPersistentConnection
        : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

        IModel CreateModel();
    }
}
