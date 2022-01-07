using Command.Interfaces;
using Command.Modules;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();

            IMessageHandler messageHandler = new MessageHandler(logger);
            INetworkingModule networkingModule = new NetworkingModule(logger);

            IWorkingModule module = new WorkingModule(networkingModule, messageHandler, logger);

            module.Run();
        }
    }
}
