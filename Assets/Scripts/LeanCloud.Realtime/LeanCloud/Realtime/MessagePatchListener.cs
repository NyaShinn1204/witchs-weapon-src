namespace LeanCloud.Realtime
{
	internal class MessagePatchListener : IAVIMListener
	{
		public OnMessagePatch OnReceived { get; set; }

		public void OnNoticeReceived(AVIMNotice notice)
		{
		}

		public bool ProtocolHook(AVIMNotice notice)
		{
			return false;
		}
	}
}
