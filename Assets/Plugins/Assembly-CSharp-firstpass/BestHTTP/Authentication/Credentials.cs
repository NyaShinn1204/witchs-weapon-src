namespace BestHTTP.Authentication
{
	public sealed class Credentials
	{
		public AuthenticationTypes Type { get; private set; }

		public string UserName { get; private set; }

		public string Password { get; private set; }

		public Credentials(string userName, string password)
		{
		}

		public Credentials(AuthenticationTypes type, string userName, string password)
		{
		}
	}
}
