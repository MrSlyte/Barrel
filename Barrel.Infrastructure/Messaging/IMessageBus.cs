namespace Barrel.Infrastructure.Messaging
{
    public interface IMessageBus
    {
        Task PublishAsync(string queue, object message);
    }
}
