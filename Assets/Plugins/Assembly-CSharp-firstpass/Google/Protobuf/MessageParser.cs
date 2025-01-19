using System;
using System.IO;

namespace Google.Protobuf
{
	public class MessageParser
	{
		private Func<IMessage> factory;

		internal MessageParser(Func<IMessage> factory)
		{
		}

		internal IMessage CreateTemplate()
		{
			return null;
		}

		public IMessage ParseFrom(byte[] data)
		{
			return null;
		}

		public IMessage ParseFrom(ByteString data)
		{
			return null;
		}

		public IMessage ParseFrom(Stream input)
		{
			return null;
		}

		public IMessage ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public IMessage ParseFrom(CodedInputStream input)
		{
			return null;
		}

		public IMessage ParseJson(string json)
		{
			return null;
		}
	}
	public sealed class MessageParser<T> : MessageParser where T : IMessage<T>
	{
		private readonly Func<T> factory;

		public MessageParser(Func<T> factory)
			: base(null)
		{
		}

		internal new T CreateTemplate()
		{
			return default(T);
		}

		public new T ParseFrom(byte[] data)
		{
			return default(T);
		}

		public new T ParseFrom(ByteString data)
		{
			return default(T);
		}

		public new T ParseFrom(Stream input)
		{
			return default(T);
		}

		public new T ParseDelimitedFrom(Stream input)
		{
			return default(T);
		}

		public new T ParseFrom(CodedInputStream input)
		{
			return default(T);
		}

		public new T ParseJson(string json)
		{
			return default(T);
		}
	}
}
