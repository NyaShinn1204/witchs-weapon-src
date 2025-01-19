namespace WaterBell.ProjX.Data.NetIO
{
	public class ServantSwitchWeaponSkin : NetMsgBase
	{
		private string weapon;

		private string skinIndex;

		public ServantSwitchWeaponSkin(string weapon, string skinIndex)
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
