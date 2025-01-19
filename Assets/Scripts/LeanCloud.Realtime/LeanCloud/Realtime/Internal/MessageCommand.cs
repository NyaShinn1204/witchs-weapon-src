using System.Collections.Generic;

namespace LeanCloud.Realtime.Internal
{
	internal class MessageCommand : AVIMCommand
	{
		public MessageCommand()
		{
		}

		public MessageCommand(AVIMCommand source)
		{
		}

		public MessageCommand ConvId(string convId)
		{
			return null;
		}

		public MessageCommand Receipt(bool receipt)
		{
			return null;
		}

		public MessageCommand Transient(bool transient)
		{
			return null;
		}

		public MessageCommand Priority(int priority)
		{
			return null;
		}

		public MessageCommand Will(bool will)
		{
			return null;
		}

		public MessageCommand Distinct(string token)
		{
			return null;
		}

		public MessageCommand Message(string msg)
		{
			return null;
		}

		public MessageCommand BinaryEncode(bool binaryEncode)
		{
			return null;
		}

		public MessageCommand PushData(IDictionary<string, object> pushData)
		{
			return null;
		}

		public MessageCommand Mention(IEnumerable<string> clientIds)
		{
			return null;
		}

		public MessageCommand MentionAll(bool mentionAll)
		{
			return null;
		}

		public MessageCommand Binary(byte[] data)
		{
			return null;
		}
	}
}
