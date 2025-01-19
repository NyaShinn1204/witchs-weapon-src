using System.Collections.Generic;

namespace LeanCloud.Realtime.Internal
{
	internal class SessionCommand : AVIMCommand
	{
		private static readonly int MESSAGE_RECALL_AND_MODIFY;

		public SessionCommand()
		{
		}

		public SessionCommand(AVIMCommand source)
		{
		}

		public SessionCommand UA(string ua)
		{
			return null;
		}

		public SessionCommand Tag(string tag)
		{
			return null;
		}

		public SessionCommand DeviceId(string deviceId)
		{
			return null;
		}

		public SessionCommand R(int r)
		{
			return null;
		}

		public SessionCommand SessionToken(string st)
		{
			return null;
		}

		public SessionCommand SessionPeerIds(IEnumerable<string> sessionPeerIds)
		{
			return null;
		}
	}
}
