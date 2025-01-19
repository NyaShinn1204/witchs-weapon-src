namespace WaterBell.ProjX.Data.NetIO
{
	public class GetActivityPlayRoleInfo : NetMsgBase
	{
		private string servantids;

		private string weaponids;

		private string levelid;

		private string fashionid;

		private string mode;

		private string Mercenarysvcardids;

		private string Mercenaryweaponcardids;

		private string buffid;

		private string difficult;

		private string isspecial;

		public GetActivityPlayRoleInfo(long[] svccardids, long[] weaponsids, long[] mercenarysvcardids, long[] mercenaryweaponcardids, int ruleType, long intanceId, string buffid = "", string difficult = "", string isspecial = "")
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
