namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantWeaponPromote : NetMsgBase
	{
		private string weapons;

		public ServantWeaponPromote(string weapons)
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
