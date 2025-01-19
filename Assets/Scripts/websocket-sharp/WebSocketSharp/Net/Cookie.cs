using System;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net
{
	[Serializable]
	public sealed class Cookie
	{
		private string _comment;

		private Uri _commentUri;

		private bool _discard;

		private string _domain;

		private DateTime _expires;

		private bool _httpOnly;

		private string _name;

		private string _path;

		private string _port;

		private int[] _ports;

		private static readonly char[] _reservedCharsForName;

		private static readonly char[] _reservedCharsForValue;

		private bool _secure;

		private DateTime _timestamp;

		private string _value;

		private int _version;

		[CompilerGenerated]
		private bool _003CExactDomain_003Ek__BackingField;

		internal bool ExactDomain
		{
			[CompilerGenerated]
			set
			{
				_003CExactDomain_003Ek__BackingField = value;
			}
		}

		public string Comment
		{
			set
			{
			}
		}

		public Uri CommentUri
		{
			set
			{
			}
		}

		public bool Discard
		{
			set
			{
			}
		}

		public string Domain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Expired
		{
			get
			{
				return false;
			}
		}

		public DateTime Expires
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public bool HttpOnly
		{
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Port
		{
			set
			{
			}
		}

		public bool Secure
		{
			set
			{
			}
		}

		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Version
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		static Cookie()
		{
		}

		public Cookie()
		{
		}

		public Cookie(string name, string value)
		{
		}

		private static bool canSetName(string name, out string message)
		{
			message = null;
			return false;
		}

		private static bool canSetValue(string value, out string message)
		{
			message = null;
			return false;
		}

		private static int hash(int i, int j, int k, int l, int m)
		{
			return 0;
		}

		private static bool tryCreatePorts(string value, out int[] result, out string parseError)
		{
			result = null;
			parseError = null;
			return false;
		}

		internal string ToRequestString(Uri uri)
		{
			return null;
		}

		public override bool Equals(object comparand)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
