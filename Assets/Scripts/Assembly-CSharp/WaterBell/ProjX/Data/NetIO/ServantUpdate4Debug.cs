using WaterBell.LevelDesign;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantUpdate4Debug : NetMsgBase
	{
		private PlayerCfgSimulator cfg;

		public ServantUpdate4Debug(PlayerCfgSimulator cfgSimulator)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static void ParseProtoBuf(byte[] data)
		{
		}
	}
}
