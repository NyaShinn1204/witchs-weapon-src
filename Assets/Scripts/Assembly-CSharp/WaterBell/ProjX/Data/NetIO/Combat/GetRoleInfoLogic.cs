namespace WaterBell.ProjX.Data.NetIO.Combat
{
	public class GetRoleInfoLogic : NetMsgBase
	{
		private string[] svCardIDStrArr;

		private string[] svWeaponIDStrArr;

		private string InstanceID;

		public GetRoleInfoLogic(long intanceId, long[] svCardIDArr, long[] svWeaponIDArr)
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
