namespace BestHTTP.SignalR.Authentication
{
	internal class HeaderAuthenticator : IAuthenticationProvider
	{
		public string User { get; private set; }

		public string Roles { get; private set; }

		public bool IsPreAuthRequired
		{
			get
			{
				return false;
			}
		}

		public event OnAuthenticationSuccededDelegate OnAuthenticationSucceded
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnAuthenticationFailedDelegate OnAuthenticationFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public HeaderAuthenticator(string user, string roles)
		{
		}

		public void StartAuthentication()
		{
		}

		public void PrepareRequest(HTTPRequest request, RequestTypes type)
		{
		}
	}
}
