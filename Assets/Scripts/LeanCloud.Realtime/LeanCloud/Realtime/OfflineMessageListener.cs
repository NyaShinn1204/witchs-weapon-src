using System;

namespace LeanCloud.Realtime
{
	internal class OfflineMessageListener : IAVIMListener
	{
		private EventHandler<AVIMMessageEventArgs> m_OnOfflineMessageReceived;

		public event EventHandler<AVIMMessageEventArgs> OnOfflineMessageReceived
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
