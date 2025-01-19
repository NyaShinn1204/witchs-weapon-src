namespace WaterBell.ProjX.Data.NetIO.Combat
{
	public class GetMobInfoLogic : NetMsgBase
	{
		private string instID;

		public override string offlineValue
		{
			get
			{
				return null;
			}
		}

		public GetMobInfoLogic(string instID)
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
