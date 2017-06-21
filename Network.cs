using System;
using System.Collections.Generic;

namespace Solid
{
	public class Network
	{
		private Email notifier;
		public List<Subscriber> Subscribers { get; set; }

		public Network()
		{
			notifier = new Email();
			Subscribers = new List<Subscriber>();
		}

		public void SendNotification(string message)
		{
			notifier.Send(Subscribers, message);
		}
	}
}