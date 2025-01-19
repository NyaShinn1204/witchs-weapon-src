using System;

namespace LeanCloud.Realtime
{
	internal class SessionListener : IAVIMListener
	{
		private Action<int, string, string> _onSessionClosed;

		public event Action<int, string, string> OnSessionClosed
		{
			add
			{
			}
			remove
			{
			}
		}

		public void OnNoticeReceived(AVIMNotice notice)
		{
		}

		public bool ProtocolHook(AVIMNotice notice)
		{
			return false;
		}
	}
}
