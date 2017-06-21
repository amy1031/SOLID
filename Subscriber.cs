using System;
using Solid.Interfaces;

namespace Solid
{
    public class Subscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public virtual void Notify(INotify notify, string message)
        {
			notify.PrintNotification($"Person: {Name}", message);
        }
    }
}