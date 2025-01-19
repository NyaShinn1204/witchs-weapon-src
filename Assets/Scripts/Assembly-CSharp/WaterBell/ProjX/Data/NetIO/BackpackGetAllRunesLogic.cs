using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class BackpackGetAllRunesLogic : NetMsgBase
	{
		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnInternalError(string detail)
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}

		public static void ParseProtoBuf(byte[] data)
		{
		}

		public static void ParseJsonData(JsonData data)
		{
		}
	}
}
