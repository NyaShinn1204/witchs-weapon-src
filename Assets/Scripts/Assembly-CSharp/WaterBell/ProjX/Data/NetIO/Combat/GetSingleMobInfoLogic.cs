namespace WaterBell.ProjX.Data.NetIO.Combat
{
	public class GetSingleMobInfoLogic : NetMsgBase
	{
		private long mid;

		private int mtype;

		private int mlevel;

		public override string offlineValue
		{
			get
			{
				return null;
			}
		}

		public GetSingleMobInfoLogic(long mobID, int mobType, int mobLv)
		{
		}

		public override void OnInternalError(string detail)
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
