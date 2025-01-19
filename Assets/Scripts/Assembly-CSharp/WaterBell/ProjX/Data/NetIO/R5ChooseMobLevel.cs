namespace WaterBell.ProjX.Data.NetIO
{
	public class R5ChooseMobLevel : NetMsgBase
	{
		private string mobLevel;

		private string difficult;

		private string isspecial;

		public R5ChooseMobLevel(string difficult, string isspecial, string mobLevel)
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
