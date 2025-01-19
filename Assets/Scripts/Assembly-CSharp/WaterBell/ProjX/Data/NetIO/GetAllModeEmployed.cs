using Google.Protobuf.Collections;
using Guildmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetAllModeEmployed : NetMsgBase
	{
		public RepeatedField<Mercenary> Mercenaries;

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
