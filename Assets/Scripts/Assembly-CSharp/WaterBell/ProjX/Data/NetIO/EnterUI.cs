namespace WaterBell.ProjX.Data.NetIO
{
	public class EnterUI : NetMsgBase
	{
		private string typeid;

		public EnterUI(string typeid)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static void ParseProtoBuf(byte[] data)
		{
		}

		public override void OnInternalError(string detail)
		{
		}
	}
}
