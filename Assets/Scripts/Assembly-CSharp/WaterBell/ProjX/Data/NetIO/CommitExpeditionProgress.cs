using System.Collections.Generic;

namespace WaterBell.ProjX.Data.NetIO
{
	public class CommitExpeditionProgress : NetMsgBase
	{
		private List<long> sids;

		private List<int> energy;

		private int hp;

		private int state;

		private string data;

		public CommitExpeditionProgress(List<long> sids, List<int> energy, int hp, int state, string data)
		{
		}

		protected override void SetIsCommonAndContentName()
		{
		}

		protected override void AddArgumentsBeforeSend()
		{
		}

		public override void SendMsg()
		{
		}

		public override void OnData(string text, string URL, string type, string tag = null)
		{
		}
	}
}
