using System.Runtime.InteropServices;
using Actionmod;

namespace WaterBell.ProjX.Data.NetIO
{
	public class ActivityStoryLose : NetMsgBase
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void dealResult(ExtraInfo ExtraInfo);

		private string baseid;

		private string serial;

		public event dealResult DearResult
		{
			add
			{
			}
			remove
			{
			}
		}

		public ActivityStoryLose(string baseid, string serial)
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
