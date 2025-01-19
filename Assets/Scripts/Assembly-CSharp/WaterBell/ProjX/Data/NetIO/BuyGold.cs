using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Data.NetIO
{
	public class BuyGold : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int mult);

		public dealResult DearResult;

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
