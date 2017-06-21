using System;
using System.Collections.Generic;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new Email();
            var text = new Text();
			var network = new Network(email);

			network.Subscribers.AddRange(new List<Subscriber>
			{
                new Subscriber("Alex"),
                new Subscriber("Brett"),
                new Subscriber("Casey"),
                new Subscriber("Chris"),
                new Subscriber("Darryl"),
                new Subscriber("Jan"),
                new Subscriber("Kerry"),
                new Subscriber("Kelly"),
                new Business("Henry's House of Hemp")
			});

			network.SendNotification("This is a test of the emergency broadcast system.");
		}
    }
}
