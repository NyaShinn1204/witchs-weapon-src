using System.Runtime.InteropServices;
using Actionmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityPlayWin : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(ExtraInfo ExtraInfo);

		private string floor;

		private string mode;

		private string levelid;

		private string apMultTime;

		private string difficult;

		private string isspecial;

		private string QuestRemainningTime;

		private string buffid;

		public event dealResult DearResult
		{
			add
			{
			}
			remove
			{
			}
		}

		public ActivityPlayWin(string floor, string mode, string levelid, string apMultTime, string buffid, string RemainningTime, string difficult = "", string isspecial = "")
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
