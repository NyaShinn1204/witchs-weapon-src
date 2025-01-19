using System.Runtime.InteropServices;
using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class AccountUpdatePassReqVerification : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(string account, string errorcode, string value);

		private dealResult dearResult;

		private string account;

		private string mflag;

		private string usertype;

		private string uid;

		public AccountUpdatePassReqVerification(string account, string mflag, string usertype, string uid)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnData(JsonData jsonValueData)
		{
		}
	}
}
