namespace LeanCloud.Realtime
{
	public interface IAVIMListener
	{
		bool ProtocolHook(AVIMNotice notice);

		void OnNoticeReceived(AVIMNotice notice);
	}
}
