using System;

namespace LeanCloud.Realtime
{
	public class AVIMKickedListener : IAVIMListener
	{
		private EventHandler<AVIMOnKickedEventArgs> m_OnKicked;

		public event EventHandler<AVIMOnKickedEventArgs> OnKicked
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
