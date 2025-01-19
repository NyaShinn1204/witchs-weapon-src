namespace WaterBell.ProjX.Data.NetIO
{
	public class EditPrivilege : NetMsgBase
	{
		private string guildid;

		private string targetid;

		private string targetposition;

		public EditPrivilege(string guildid, string target, string targetposition)
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
