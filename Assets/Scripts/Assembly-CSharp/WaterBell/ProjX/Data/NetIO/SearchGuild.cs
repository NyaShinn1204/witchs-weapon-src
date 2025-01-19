using Google.Protobuf.Collections;
using Guildmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class SearchGuild : NetMsgBase
	{
		public RepeatedField<AllGuildInfo.Types.Info> Data;

		private string guildname;

		public SearchGuild(string guildname)
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
