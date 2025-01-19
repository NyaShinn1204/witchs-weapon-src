using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace WebSocketSharp.Net
{
	[Serializable]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		private static readonly Dictionary<string, HttpHeaderInfo> _headers;

		private bool _internallyUsed;

		private HttpHeaderType _state;

		public override string[] AllKeys
		{
			get
			{
				return null;
			}
		}

		public override int Count
		{
			get
			{
				return 0;
			}
		}

		public override KeysCollection Keys
		{
			get
			{
				return null;
			}
		}

		static WebHeaderCollection()
		{
		}

		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public WebHeaderCollection()
		{
		}

		private void add(string name, string value, bool ignoreRestricted)
		{
		}

		private void addWithoutCheckingName(string name, string value)
		{
		}

		private void addWithoutCheckingNameAndRestricted(string name, string value)
		{
		}

		private static int checkColonSeparated(string header)
		{
			return 0;
		}

		private static HttpHeaderType checkHeaderType(string name)
		{
			return default(HttpHeaderType);
		}

		private static string checkName(string name)
		{
			return null;
		}

		private void checkRestricted(string name)
		{
		}

		private void checkState(bool response)
		{
		}

		private static string checkValue(string value)
		{
			return null;
		}

		private void doWithCheckingState(Action<string, string> action, string name, string value, bool setState)
		{
		}

		private void doWithCheckingState(Action<string, string> action, string name, string value, bool response, bool setState)
		{
		}

		private void doWithoutCheckingName(Action<string, string> action, string name, string value)
		{
		}

		private static HttpHeaderInfo getHeaderInfo(string name)
		{
			return null;
		}

		private static bool isRestricted(string name, bool response)
		{
			return false;
		}

		private void removeWithoutCheckingName(string name, string unuse)
		{
		}

		private void setWithoutCheckingName(string name, string value)
		{
		}

		internal void InternalSet(string header, bool response)
		{
		}

		internal void InternalSet(string name, string value, bool response)
		{
		}

		internal static bool IsHeaderName(string name)
		{
			return false;
		}

		internal static bool IsHeaderValue(string value)
		{
			return false;
		}

		internal static bool IsMultiValue(string headerName, bool response)
		{
			return false;
		}

		public override void Add(string name, string value)
		{
		}

		public override void Clear()
		{
		}

		public override string Get(int index)
		{
			return null;
		}

		public override string Get(string name)
		{
			return null;
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override string GetKey(int index)
		{
			return null;
		}

		public override string[] GetValues(int index)
		{
			return null;
		}

		public override string[] GetValues(string header)
		{
			return null;
		}

		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public override void OnDeserialization(object sender)
		{
		}

		public override void Remove(string name)
		{
		}

		public override void Set(string name, string value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
