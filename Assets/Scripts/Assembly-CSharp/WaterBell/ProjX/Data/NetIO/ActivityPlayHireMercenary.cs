namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityPlayHireMercenary : NetMsgBase
	{
		private string mercenaryownerids;

		private string mercenarysvcardids;

		private string mercenarygarrisontimes;

		public ActivityPlayHireMercenary(string mercenarysvcardids, string mercenaryownerids, string mercenarygarrisontimes)
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
