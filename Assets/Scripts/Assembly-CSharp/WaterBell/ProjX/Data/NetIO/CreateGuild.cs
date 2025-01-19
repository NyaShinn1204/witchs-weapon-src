namespace WaterBell.ProjX.Data.NetIO
{
	public class CreateGuild : NetMsgBase
	{
		private string guildName;

		private string guildSlogan;

		private string emblem;

		private string emblemborder;

		private string emblembackground;

		private string emblemColor;

		private string emblemborderColor;

		private string emblembackgroundColor;

		public CreateGuild(string name, string slogan, string emblem, string emblemborder, string emblembackground, string emblemColor, string emblemborderColor, string emblembackgroundColor)
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
