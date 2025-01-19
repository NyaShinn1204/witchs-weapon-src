namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityChanllengeStartBattle : NetMsgBase
	{
		private string baseid;

		private string serial;

		private string mode;

		private string instanceid;

		private string extraargu;

		public ActivityChanllengeStartBattle(string baseid, string serial, string mode, string instanceid, string extraargu)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}
	}
}
