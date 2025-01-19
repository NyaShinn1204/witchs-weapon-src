using System;
using System.Collections.Generic;
using BestHTTP.SignalRCore.Messages;

namespace BestHTTP.SignalRCore
{
	public sealed class JsonProtocol : IProtocol
	{
		public const char Separator = '\u001e';

		public TransferModes Type
		{
			get
			{
				return default(TransferModes);
			}
		}

		public IEncoder Encoder { get; private set; }

		public HubConnection Connection { get; set; }

		public JsonProtocol(IEncoder encoder)
		{
		}

		public void ParseMessages(string data, ref List<Message> messages)
		{
		}

		public void ParseMessages(byte[] data, ref List<Message> messages)
		{
		}

		public byte[] EncodeMessage(Message message)
		{
			return null;
		}

		public object[] GetRealArguments(Type[] argTypes, object[] arguments)
		{
			return null;
		}

		public object ConvertTo(Type toType, object obj)
		{
			return null;
		}

		public static byte[] WithSeparator(string str)
		{
			return null;
		}
	}
}
