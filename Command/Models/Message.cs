using Command.Interfaces;
using System;

namespace Command.Models
{
    public record Message(string Text, int Length, Action<string, int> CallbackFunction, INetworkingModule Addressee);
}
