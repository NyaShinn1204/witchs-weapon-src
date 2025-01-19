namespace WaterBell.ProjX.Data.NetIO
{
	public class BuyStoryGroup : NetMsgBase
	{
		private string _ID;

		public BuyStoryGroup(string sID)
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
