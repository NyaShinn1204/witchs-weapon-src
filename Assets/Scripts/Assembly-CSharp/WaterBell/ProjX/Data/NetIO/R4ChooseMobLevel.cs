namespace WaterBell.ProjX.Data.NetIO
{
	public class R4ChooseMobLevel : NetMsgBase
	{
		private string mobLevel;

		public R4ChooseMobLevel(string mobLevel)
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
