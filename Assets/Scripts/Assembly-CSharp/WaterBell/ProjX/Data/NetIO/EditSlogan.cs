namespace WaterBell.ProjX.Data.NetIO
{
	public class EditSlogan : NetMsgBase
	{
		private string guildid;

		private string content;

		public EditSlogan(string guildid, string content)
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
