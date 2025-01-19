using System;

namespace LeanCloud.Realtime
{
	public class AVIMTextMessageListener : IAVIMListener
	{
		private EventHandler<AVIMTextMessageEventArgs> m_OnTextMessageReceived;

		public event EventHandler<AVIMTextMessageEventArgs> OnTextMessageReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public AVIMTextMessageListener()
		{
		}

		public AVIMTextMessageListener(Action<AVIMTextMessage> textMessageReceived)
		{
		}

		public virtual bool ProtocolHook(AVIMNotice notice)
		{
			return false;
		}

		public virtual void OnNoticeReceived(AVIMNotice notice)
		{
		}
	}
}
