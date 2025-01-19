namespace WaterBell.ProjX.Data.NetIO
{
	public class RoleRenameLogic : NetMsgBase
	{
		private string roleName;

		public RoleRenameLogic(string rName)
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
