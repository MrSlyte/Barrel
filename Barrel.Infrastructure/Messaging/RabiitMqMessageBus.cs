using System.Text.Json;

namespace Barrel.Infrastructure.Messaging
{
    public class RabbitMqMessageBus : IMessageBus
    {
        public Task PublishAsync(string queue, object message)
        {
            // mock para HelloWorld
            Console.WriteLine($"[RabbitMQ] Publicado em {queue}: {JsonSerializer.Serialize(message)}");
            return Task.CompletedTask;
        }
    }
}
