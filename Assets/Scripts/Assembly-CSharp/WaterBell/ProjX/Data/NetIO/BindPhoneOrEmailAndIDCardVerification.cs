using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Lootmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class BindPhoneOrEmailAndIDCardVerification : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(ModelCollection<DrawResultData> loot, ModelCollection<DrawResultData> Weapon);

		private dealResult dearResult;

		private string flag;

		private string email;

		private string phone;

		private string password;

		private string checekcode;

		private string name;

		private string identity;

		public dealResult DealResult
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BindPhoneOrEmailAndIDCardVerification(string flag, string email, string phone, string password, string code, string name, string identity)
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

		private void dealReceivePhoneRewardResult(int result, RepeatedField<LootObject> loots)
		{
		}
	}
}
