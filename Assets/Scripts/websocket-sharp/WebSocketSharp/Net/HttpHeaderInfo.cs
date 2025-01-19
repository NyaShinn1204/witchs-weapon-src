namespace WebSocketSharp.Net
{
	internal class HttpHeaderInfo
	{
		private string _name;

		private HttpHeaderType _type;

		internal bool IsMultiValueInRequest
		{
			get
			{
				return false;
			}
		}

		internal bool IsMultiValueInResponse
		{
			get
			{
				return false;
			}
		}

		public bool IsRequest
		{
			get
			{
				return false;
			}
		}

		public bool IsResponse
		{
			get
			{
				return false;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		internal HttpHeaderInfo(string name, HttpHeaderType type)
		{
		}

		public bool IsMultiValue(bool response)
		{
			return false;
		}

		public bool IsRestricted(bool response)
		{
			return false;
		}
	}
}
