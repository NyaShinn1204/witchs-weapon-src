namespace WaterBell.ProjX.Data.NetIO
{
	public class ResetActivityPlay : NetMsgBase
	{
		private string floor;

		private string mode;

		private string difficult;

		private string isspecial;

		private string giveup;

		private string mobLevel;

		public ResetActivityPlay(int floor, int mode, string difficult = "", string isspecial = "", string giveup = "", string mobLevel = "")
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
