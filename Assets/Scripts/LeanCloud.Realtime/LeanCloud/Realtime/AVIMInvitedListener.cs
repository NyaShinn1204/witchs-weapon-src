using System;

namespace LeanCloud.Realtime
{
	public class AVIMInvitedListener : IAVIMListener
	{
		private EventHandler<AVIMOnInvitedEventArgs> m_OnInvited;

		public event EventHandler<AVIMOnInvitedEventArgs> OnInvited
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
