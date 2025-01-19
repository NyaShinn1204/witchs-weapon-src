namespace WaterBell.ProjX.Data.NetIO
{
	public class StartBattleLogic : NetMsgBase
	{
		private string instID;

		private string targetWeapon;

		public override string offlineValue
		{
			get
			{
				return null;
			}
		}

		public StartBattleLogic(string instID, string targetWeapon = "")
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
