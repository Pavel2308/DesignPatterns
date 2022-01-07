using Command.Models;

namespace Command.Interfaces
{
    public interface IMessageHandler : IModule
    {
        void HandleMessage(Message message);
    }
}
