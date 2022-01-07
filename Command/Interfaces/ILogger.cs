using System;

namespace Command.Interfaces
{
    public interface ILogger
    {
        void Log(string service, string action, DateTime dateTime);
    }
}
