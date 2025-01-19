using Google.Protobuf.Collections;
using Guildmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetAllGuildsByMember : NetMsgBase
	{
		public RepeatedField<AllGuildInfo.Types.Info> Data;

		private string page;

		public int PageNum;

		public GetAllGuildsByMember(string page)
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
