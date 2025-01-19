using System;

namespace LeanCloud.Realtime
{
	public class AVIMMessageListener : IAVIMListener
	{
		private EventHandler<AVIMMessageEventArgs> m_OnMessageReceived;

		public event EventHandler<AVIMMessageEventArgs> OnMessageReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public virtual bool ProtocolHook(AVIMNotice notice)
		{
			return false;
		}

		internal virtual void OnMessage(AVIMNotice notice)
		{
		}

		public virtual void OnNoticeReceived(AVIMNotice notice)
		{
		}
	}
}
