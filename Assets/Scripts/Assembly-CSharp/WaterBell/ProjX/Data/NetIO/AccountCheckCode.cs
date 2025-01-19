using System.Runtime.InteropServices;
using LitJson;

namespace WaterBell.ProjX.Data.NetIO
{
	public class AccountCheckCode : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(string value);

		public dealResult dearResult;

		private string account;

		private string validatingCode;

		private string usertype;

		private string mflag;

		private string uid;

		public AccountCheckCode(string account, string code, string usertype, string mflag, string uid)
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
