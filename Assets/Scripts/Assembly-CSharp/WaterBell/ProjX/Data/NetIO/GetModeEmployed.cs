using Google.Protobuf.Collections;
using Guildmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetModeEmployed : NetMsgBase
	{
		public RepeatedField<Mercenary> Mercenaries;

		private string guildid;

		private string mode;

		public GetModeEmployed(string guildid, string mode)
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
