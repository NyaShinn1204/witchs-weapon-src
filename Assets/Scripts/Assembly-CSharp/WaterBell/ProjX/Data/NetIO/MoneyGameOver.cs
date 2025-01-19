namespace WaterBell.ProjX.Data.NetIO
{
	public class MoneyGameOver : NetMsgBase
	{
		private string grade;

		private int bonusNum;

		private long propID;

		private int count;

		public MoneyGameOver(string sGrade, int sBonusNum, long sPropID, int sCount)
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
