using BestHTTP;

namespace WaterBell.ProjX.Data.NetIO
{
	public class DebugProtocolLevelUpdate : NetMsgBase
	{
		protected override void AddArgumentsBeforeSend()
		{
		}

		protected override void Init(params string[] names)
		{
		}

		protected override void SetIsCommonAndContentName()
		{
		}

		public override void OnError(string detail)
		{
		}

		public override void OnInternalError(string detail)
		{
		}

		public override void OnTimeOut(HTTPRequestStates status)
		{
		}

		public override void SendMsg()
		{
		}

		public override void OnData(string text, string URL, string type, string tag)
		{
		}
	}
}
