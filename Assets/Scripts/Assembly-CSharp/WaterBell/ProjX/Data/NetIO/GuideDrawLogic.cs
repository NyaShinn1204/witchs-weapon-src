using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class GuideDrawLogic : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int result, RepeatedField<LootObject> loots);

		private int serial;

		private dealResult dearResult;

		public dealResult DearResult
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GuideDrawLogic(int drawSerial)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnInternalError(string detail)
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
