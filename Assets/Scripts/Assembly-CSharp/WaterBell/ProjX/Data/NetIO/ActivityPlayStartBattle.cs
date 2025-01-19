namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityPlayStartBattle : NetMsgBase
	{
		private string levelid;

		private string buffid;

		private string floor;

		private string difficult;

		private string isspecial;

		private string confirmbuff;

		public ActivityPlayStartBattle(string levelid, string floor = "1", string buffid = "1", string difficult = "1", string isspecial = "false", string confirmbuff = "0")
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
