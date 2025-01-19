using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using LitJson;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class UpdateQuest : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(int result, RepeatedField<LootObject> loots);

		private string jobid;

		private string typeid;

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

		public UpdateQuest(string jobid, string typeid)
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

		public override void OnInternalError(string detail)
		{
		}

		public static void ParseJsonData(JsonData data)
		{
		}
	}
}
