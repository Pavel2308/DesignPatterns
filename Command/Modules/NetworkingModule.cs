using Command.Interfaces;
using System;

namespace Command.Modules
{
    public class NetworkingModule : INetworkingModule
    {
        public string ServiceName => "сетевой модуль";

        private readonly ILogger _logger;

        public NetworkingModule(ILogger logger) 
        {
            _logger = logger;
        }

        public void ReceiveMessage(string text, int length, Action<string, int> callbackFunction)
        {
            _logger.Log(ServiceName, $"сообщение \"{text}\" получено", DateTime.Now);
            callbackFunction(text, length);
        }
    }
}
