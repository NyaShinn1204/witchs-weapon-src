namespace WaterBell.ProjX.Data.NetIO
{
	public class GetCSCRoleInfo : NetMsgBase
	{
		private string ServantCardIds;

		private string WeaponIds;

		private string Fashioncardid;

		private string Mercenarysvcardids;

		private string Mercenaryweaponcardids;

		private string InstanceID;

		public GetCSCRoleInfo(long[] svccardids, long[] weaponsids, long[] mercenarysvcardids, long[] mercenaryweaponcardids, long intanceId)
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
