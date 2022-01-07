using Command.Interfaces;
using System;

namespace Command
{
    public class Logger : ILogger
    {
        public void Log(string serviceName, string actionName, DateTime dateTime)
        {
            Console.WriteLine($"Сервис: {serviceName}; Действие: {actionName}; Дата и время: {dateTime};");
        }
    }
}
