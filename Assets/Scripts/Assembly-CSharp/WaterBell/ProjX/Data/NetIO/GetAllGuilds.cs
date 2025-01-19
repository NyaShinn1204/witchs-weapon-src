using Google.Protobuf.Collections;
using Guildmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetAllGuilds : NetMsgBase
	{
		public RepeatedField<AllGuildInfo.Types.Info> Data;

		private string guildname;

		private string page;

		public int PageNum;

		public GetAllGuilds(string page)
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
