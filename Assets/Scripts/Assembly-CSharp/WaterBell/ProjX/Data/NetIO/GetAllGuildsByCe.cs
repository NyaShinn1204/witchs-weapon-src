using Google.Protobuf.Collections;
using Guildmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetAllGuildsByCe : NetMsgBase
	{
		public RepeatedField<AllGuildInfo.Types.Info> Data;

		public int PageNum;

		private string page;

		public GetAllGuildsByCe(string page)
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
