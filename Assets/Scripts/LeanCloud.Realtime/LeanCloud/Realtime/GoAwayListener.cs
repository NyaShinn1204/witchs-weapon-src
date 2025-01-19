using System;

namespace LeanCloud.Realtime
{
	internal class GoAwayListener : IAVIMListener
	{
		private Action onGoAway;

		public event Action OnGoAway
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
