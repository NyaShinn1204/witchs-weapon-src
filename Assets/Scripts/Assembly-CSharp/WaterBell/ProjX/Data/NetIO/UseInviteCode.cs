namespace WaterBell.ProjX.Data.NetIO
{
	public class UseInviteCode : NetMsgBase
	{
		private string invitecode;

		public UseInviteCode(string invitecode)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public void ParseProtoBuf(byte[] data)
		{
		}
	}
}
