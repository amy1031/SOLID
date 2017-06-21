using System.Collections.Generic;

namespace Solid.Interfaces
{
    public interface INotify
    {
        void Send(List<Subscriber> subscribers, string message);
        void Send(Subscriber subscriber, string message);
        void PrintNotification(string tagLine, string message);
    }
}