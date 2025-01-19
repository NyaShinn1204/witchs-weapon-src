using System;
using BestHTTP.Cookies;

namespace BestHTTP.SignalR.Authentication
{
	public sealed class SampleCookieAuthentication : IAuthenticationProvider
	{
		private HTTPRequest AuthRequest;

		private Cookie Cookie;

		public Uri AuthUri { get; private set; }

		public string UserName { get; private set; }

		public string Password { get; private set; }

		public string UserRoles { get; private set; }

		public bool IsPreAuthRequired { get; private set; }

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

		public SampleCookieAuthentication(Uri authUri, string user, string passwd, string roles)
		{
		}

		public void StartAuthentication()
		{
		}

		public void PrepareRequest(HTTPRequest request, RequestTypes type)
		{
		}

		private void OnAuthRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}
	}
}
