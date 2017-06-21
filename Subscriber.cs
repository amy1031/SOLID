using System;

namespace Solid
{
	public class Subscriber
	{
		public string Name { get; set; }

		public Subscriber(string name)
		{
			Name = name;
		}

		public void Notify(string message)
		{
			Console.WriteLine($"Person: {Name}");
			Console.WriteLine($"Email: {message}");
			Console.WriteLine("");
		}
	}
}