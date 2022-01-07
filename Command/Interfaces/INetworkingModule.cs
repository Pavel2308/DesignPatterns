using System;
namespace Command.Interfaces
{
    public interface INetworkingModule : IModule
    {
        void ReceiveMessage(string text, int length, Action<string, int> callbackFunction);
    }
}
