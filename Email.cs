using System;
using System.Collections.Generic;

namespace Solid
{
	public class Email
	{
		public void Send(List<Subscriber> subscribers, string message)
		{
			foreach(var subscriber in subscribers)
			{
				Send(subscriber, message);
			}
		}

		public void Send(Subscriber subscriber, string message)
		{
			subscriber.Notify(message);
		}

		public void SendText(List<Subscriber> subscribers, string message)
		{
			foreach(var subscriber in subscribers)
			{
				SendText(subscriber, message);
			}
		}

		public void SendText(Subscriber subscriber, string message)
		{
			subscriber.Notify(message);
		}	
	}
}