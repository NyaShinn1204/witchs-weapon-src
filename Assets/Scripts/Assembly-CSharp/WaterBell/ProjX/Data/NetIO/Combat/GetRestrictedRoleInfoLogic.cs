namespace WaterBell.ProjX.Data.NetIO.Combat
{
	public class GetRestrictedRoleInfoLogic : NetMsgBase
	{
		private long challengeID;

		private string[] svCardIDStrArr;

		private string[] svWeaponIDStrArr;

		public GetRestrictedRoleInfoLogic(long instanceID, long challengeID, long[] svCardIDArr = null, long[] svWeaponIDArr = null)
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
