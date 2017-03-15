namespace Solid
{
	// This class violates the 'Dependency Inversion' principle
	// What if we wanted to send a different type of notification?
	
	public class Notification
	{
        	private Email email;

		public Notification()
		{
			this.email = new Email();
        	}

		public void SendNotification()
		{
            		this.email.Send();
        	}
    	}

	public class Email
	{
		public void Send()
		{

		}
	}
}
