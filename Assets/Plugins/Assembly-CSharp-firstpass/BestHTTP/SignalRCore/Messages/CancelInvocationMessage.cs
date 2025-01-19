using System.Runtime.InteropServices;

namespace BestHTTP.SignalRCore.Messages
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct CancelInvocationMessage
	{
		public string invocationId;

		public MessageTypes type
		{
			get
			{
				return default(MessageTypes);
			}
		}
	}
}
