namespace WaterBell.ProjX.Data.NetIO
{
	public class RoleCreateAndLogin : NetMsgBase
	{
		private bool isCreate;

		private string createZID;

		public RoleCreateAndLogin(bool isCreate = false, string createZID = "")
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
