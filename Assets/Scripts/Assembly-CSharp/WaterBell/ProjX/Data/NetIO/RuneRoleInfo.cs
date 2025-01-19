namespace WaterBell.ProjX.Data.NetIO
{
	public class RuneRoleInfo : NetMsgBase
	{
		private string runes;

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static void ParseProtoBuf(byte[] data)
		{
		}
	}
}
