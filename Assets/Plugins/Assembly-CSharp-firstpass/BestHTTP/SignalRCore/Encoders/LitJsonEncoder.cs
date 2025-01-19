using System;

namespace BestHTTP.SignalRCore.Encoders
{
	public sealed class LitJsonEncoder : IEncoder
	{
		public string Name
		{
			get
			{
				return null;
			}
		}

		public T DecodeAs<T>(string text)
		{
			return default(T);
		}

		public T DecodeAs<T>(byte[] data)
		{
			return default(T);
		}

		public byte[] EncodeAsBinary<T>(T value)
		{
			return null;
		}

		public string EncodeAsText<T>(T value)
		{
			return null;
		}

		public object ConvertTo(Type toType, object obj)
		{
			return null;
		}
	}
}
