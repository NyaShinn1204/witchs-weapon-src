namespace WaterBell.ProjX.Data.NetIO
{
	public class PushWeaponDailyProgress : NetMsgBase
	{
		private bool isWin;

		private int starNum;

		private long combatscore;

		private string wantweapon;

		public override string offlineValue
		{
			get
			{
				return null;
			}
		}

		public PushWeaponDailyProgress(bool isWin, int starNum, long combatscore, string wantweapon)
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
