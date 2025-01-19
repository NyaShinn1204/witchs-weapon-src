namespace WaterBell.ProjX.Data.NetIO
{
	public class LevelResetElites : NetMsgBase
	{
		private string chapid;

		private string instanceid;

		public LevelResetElites(string chapid, string instanceid)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		protected override void Init(params string[] names)
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public void ParseProtoBuf(byte[] data)
		{
		}
	}
}
