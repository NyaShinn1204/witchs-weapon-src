using NodeCanvas.Framework;
using WaterBell.ProjX.Data.NetIO;

namespace NodeCanvas.Tasks.Actions
{
	public class SendMsg2SpecialMail : GuideTask
	{
		private NetMsgSeq.FinishSeqHandler FinishSeqHandler;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		private void FinishSeqHandlerFunc()
		{
		}
	}
}
