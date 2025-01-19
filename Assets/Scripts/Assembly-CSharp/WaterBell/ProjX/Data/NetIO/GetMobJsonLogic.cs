namespace WaterBell.ProjX.Data.NetIO
{
	public class GetMobJsonLogic : NetMsgBase
	{
		private string instID;

		public override string offlineValue
		{
			get
			{
				return null;
			}
		}

		public GetMobJsonLogic(string instID)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnInternalError(string detail)
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		private void StatInfo()
		{
		}
	}
}
