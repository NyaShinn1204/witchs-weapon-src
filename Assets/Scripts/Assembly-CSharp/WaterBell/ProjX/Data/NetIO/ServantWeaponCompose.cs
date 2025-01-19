namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantWeaponCompose : NetMsgBase
	{
		private string weapons;

		public ServantWeaponCompose(string weapons)
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
