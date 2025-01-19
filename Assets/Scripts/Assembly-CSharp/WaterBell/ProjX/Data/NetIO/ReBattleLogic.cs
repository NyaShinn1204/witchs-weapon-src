namespace WaterBell.ProjX.Data.NetIO
{
	public class ReBattleLogic : NetMsgBase
	{
		private string instID;

		public override string offlineValue
		{
			get
			{
				return null;
			}
		}

		public ReBattleLogic(string instID)
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
