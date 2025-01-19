namespace WaterBell.ProjX.Data.NetIO
{
	public class LevelRank : NetMsgBase
	{
		private string _levelid;

		private FunctionListenerEvent _successHD;

		public LevelRank(string sLevelID, FunctionListenerEvent sSuccessHD)
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
