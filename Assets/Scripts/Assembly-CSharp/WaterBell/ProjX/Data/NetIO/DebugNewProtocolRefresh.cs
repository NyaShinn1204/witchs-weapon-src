namespace WaterBell.ProjX.Data.NetIO
{
	public class DebugNewProtocolRefresh : NetMsgBase
	{
		private string URLPattern;

		protected override void AddArgumentsBeforeSend()
		{
		}

		protected override void SetIsCommonAndContentName()
		{
		}

		public override void OnInternalError(string detail)
		{
		}

		public override void SendMsg()
		{
		}

		public override void OnData(string text, string URL, string type, string tag = null)
		{
		}
	}
}
