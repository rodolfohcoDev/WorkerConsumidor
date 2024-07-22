using Consumer.Shareable.Request;

namespace Consumer.Domain.pub.Client
{
    public interface IClientePubMessenger
    {
        Task<bool> SendMessager(ClienteRequest Model);
    }
}
