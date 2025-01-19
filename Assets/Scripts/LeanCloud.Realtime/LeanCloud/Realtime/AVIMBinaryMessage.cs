using LeanCloud.Realtime.Internal;

namespace LeanCloud.Realtime
{
	public class AVIMBinaryMessage : AVIMMessage
	{
		public byte[] BinaryData { get; set; }

		public AVIMBinaryMessage()
		{
		}

		public AVIMBinaryMessage(byte[] data)
		{
		}

		internal override MessageCommand BeforeSend(MessageCommand cmd)
		{
			return null;
		}
	}
}
