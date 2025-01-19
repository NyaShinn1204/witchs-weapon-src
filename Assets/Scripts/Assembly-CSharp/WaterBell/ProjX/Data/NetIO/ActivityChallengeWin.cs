using System.Runtime.InteropServices;
using Actionmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityChallengeWin : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(ExtraInfo ExtraInfo);

		private string baseid;

		private string serial;

		private string extraargu;

		private string pass;

		public event dealResult DearResult
		{
			add
			{
			}
			remove
			{
			}
		}

		public ActivityChallengeWin(string baseid, string serial, string pass, string extraargu)
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void OnProtoBufData(byte[] data)
		{
		}
	}
}
