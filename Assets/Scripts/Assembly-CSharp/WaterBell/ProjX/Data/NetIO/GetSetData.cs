using System.Runtime.InteropServices;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GetSetData : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealGetSetDataResult(string ids);

		public dealGetSetDataResult DealResult;

		private string ids;

		public GetSetData(string ids)
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
