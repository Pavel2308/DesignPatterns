using Command.Interfaces;
using Command.Models;
using System;

namespace Command.Modules
{
    public class MessageHandler : IMessageHandler
    {
        public string ServiceName => "обработчик сообщений";

        private readonly ILogger _logger;

        public MessageHandler(ILogger logger)
        {
            _logger = logger;
        }

        public void HandleMessage(Message message)
        {
            string text = message.Text;
            int length = message.Length;
            var callbackFunction = message.CallbackFunction;

            _logger.Log(ServiceName, $"сообщение \"{text}\" обработано", DateTime.Now);

            message.Addressee.ReceiveMessage(text, length, callbackFunction);
        }
    }
}
