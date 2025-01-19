using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ShopRefresh : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealGetSetDataResult(long id);

		public dealGetSetDataResult DealResult;

		private long id;

		public ShopRefresh(long id)
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
