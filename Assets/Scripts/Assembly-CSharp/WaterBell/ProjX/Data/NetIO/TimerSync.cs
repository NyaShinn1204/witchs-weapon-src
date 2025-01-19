using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Data.NetIO
{
	public class TimerSync : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(long RemainSecond);

		private string UTCTime;

		public dealResult DealResult;

		public TimerSync(string UTCTime)
		{
		}

		protected override void AddArgumentsBeforeSend()
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
