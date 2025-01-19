namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantWeaponSpellPromote : NetMsgBase
	{
		private string weapons;

		public ServantWeaponSpellPromote(string weapons)
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
