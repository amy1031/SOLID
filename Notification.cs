namespace Solid
{
	// this class violates the 'Dependency Inversion' principle
	
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