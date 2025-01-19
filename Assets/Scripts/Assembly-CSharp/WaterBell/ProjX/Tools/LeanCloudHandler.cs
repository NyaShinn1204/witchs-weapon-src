using System.Runtime.InteropServices;
using WaterBell.ProjX.Core.Manager;

namespace WaterBell.ProjX.Tools
{
	public class LeanCloudHandler
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void DealPayResultDelegate(long error);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void DealShipGoodsResultDelegate(string order);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void LoginDelegate();

		private static LeanCloudHandler _instance;

		public DealPayResultDelegate DealPayResult;

		public DealShipGoodsResultDelegate DealShipGoodsResult;

		public LoginDelegate LoginActions;

		public static LeanCloudHandler GetInstance()
		{
			return null;
		}

		public void ReceiveChatMsg(ChatMessage chatMessage)
		{
		}

		public void ReceiveMsg(string arg)
		{
		}

		public void GetNewMail()
		{
		}

		private void GetPayResult(long Error)
		{
		}

		private void GetShipGoodsResult(string order, string goodid = null)
		{
		}

		public void ClientLogin()
		{
		}
	}
}
