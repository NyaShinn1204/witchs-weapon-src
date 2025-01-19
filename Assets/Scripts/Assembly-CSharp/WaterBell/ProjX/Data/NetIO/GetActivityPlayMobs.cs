namespace WaterBell.ProjX.Data.NetIO
{
	public class GetActivityPlayMobs : NetMsgBase
	{
		private string floor;

		private string mode;

		private string levelid;

		private string difficult;

		private string isspecial;

		public GetActivityPlayMobs(string floor, string mode, string levelid, string difficult = "", string isspecial = "")
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
