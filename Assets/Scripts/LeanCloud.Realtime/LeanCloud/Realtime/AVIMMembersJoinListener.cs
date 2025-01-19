using System;

namespace LeanCloud.Realtime
{
	public class AVIMMembersJoinListener : IAVIMListener
	{
		private EventHandler<AVIMOnMembersJoinedEventArgs> m_OnMembersJoined;

		public event EventHandler<AVIMOnMembersJoinedEventArgs> OnMembersJoined
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
