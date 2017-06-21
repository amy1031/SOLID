using System;
using System.Collections.Generic;
using Solid.Interfaces;

namespace Solid
{
	public class Network
	{
		private INotify notifier;
		public List<Subscriber> Subscribers { get; set; }

		public Network(INotify notifier)
		{
			this.notifier = notifier;
			Subscribers = new List<Subscriber>();
		}

		public void SendNotification(string message)
		{
			notifier.Send(Subscribers, message);
		}
	}
}