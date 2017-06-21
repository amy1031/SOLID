using System;
using Solid.Interfaces;

namespace Solid
{
	public class Business : Subscriber
	{
		public Business(string name) : base(name)
		{
		}

		public override void Notify(INotify notify, string message)
		{
			notify.PrintNotification($"Business: {Name}", message);
		}
	}
}