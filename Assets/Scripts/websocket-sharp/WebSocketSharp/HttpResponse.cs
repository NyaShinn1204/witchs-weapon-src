using System;
using System.Collections.Specialized;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	internal class HttpResponse : HttpBase
	{
		private string _code;

		private string _reason;

		public CookieCollection Cookies
		{
			get
			{
				return null;
			}
		}

		public bool HasConnectionClose
		{
			get
			{
				return false;
			}
		}

		public bool IsProxyAuthenticationRequired
		{
			get
			{
				return false;
			}
		}

		public bool IsRedirect
		{
			get
			{
				return false;
			}
		}

		public bool IsUnauthorized
		{
			get
			{
				return false;
			}
		}

		public bool IsWebSocketResponse
		{
			get
			{
				return false;
			}
		}

		public string StatusCode
		{
			get
			{
				return null;
			}
		}

		private HttpResponse(string code, string reason, Version version, NameValueCollection headers)
			: base(null, null)
		{
		}

		internal static HttpResponse Parse(string[] headerParts)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
