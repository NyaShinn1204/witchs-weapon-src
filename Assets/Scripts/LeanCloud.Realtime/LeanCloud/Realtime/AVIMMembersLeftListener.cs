using System;

namespace LeanCloud.Realtime
{
	public class AVIMMembersLeftListener : IAVIMListener
	{
		private EventHandler<AVIMOnMembersLeftEventArgs> m_OnMembersLeft;

		public event EventHandler<AVIMOnMembersLeftEventArgs> OnMembersLeft
		{
			add
			{
			}
			remove
			{
			}
		}

		public virtual void OnNoticeReceived(AVIMNotice notice)
		{
		}

		public virtual bool ProtocolHook(AVIMNotice notice)
		{
			return false;
		}
	}
}
