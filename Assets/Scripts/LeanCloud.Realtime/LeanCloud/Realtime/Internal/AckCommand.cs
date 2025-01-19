namespace LeanCloud.Realtime.Internal
{
	internal class AckCommand : AVIMCommand
	{
		public AckCommand()
		{
		}

		public AckCommand(AVIMCommand source)
		{
		}

		public AckCommand Message(IAVIMMessage message)
		{
			return null;
		}

		public AckCommand MessageId(string messageId)
		{
			return null;
		}

		public AckCommand ConversationId(string conversationId)
		{
			return null;
		}

		public AckCommand FromTimeStamp(long startTimeStamp)
		{
			return null;
		}

		public AckCommand ToTimeStamp(long endTimeStamp)
		{
			return null;
		}

		public AckCommand ReadAck()
		{
			return null;
		}
	}
}
