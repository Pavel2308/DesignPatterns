using Command.Interfaces;
using Command.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Modules
{
    public class WorkingModule : IWorkingModule
    {
        public string ServiceName => "рабочий модуль";

        private const int Period = 2000;

        private readonly INetworkingModule _addressee;
        private readonly IMessageHandler _messageHandler;

        private readonly ILogger _logger;

        public WorkingModule(INetworkingModule addressee, IMessageHandler messageHandler, ILogger logger)
        {
            _addressee = addressee;
            _messageHandler = messageHandler;
            _logger = logger;
        }

        public void Run()
        {
            Task.Delay(Period).Wait();
            var message = GenerateMessage();

            _logger.Log(ServiceName, $"сгенерировано сообщение \"{message.Text}\" для отправки в {_addressee.ServiceName}", DateTime.Now);
            _logger.Log(ServiceName, $"сообщение \"{message.Text}\" отправлено в {_addressee.ServiceName}", DateTime.Now);
            _messageHandler.HandleMessage(message); ;
        }

        private void ReceiveAnswer(string text, int length)
        {
            _logger.Log(ServiceName, $"получен ответ на сообщение \"{text}\" из {_addressee.ServiceName}", DateTime.Now);
            Run();
        }

        private Message GenerateMessage()
        {
            Random rand = new Random();
            string text = rand.Next().ToString();
            var message = new Message(text, text.Count(), ReceiveAnswer, _addressee);

            return message;
        }
    }
}
