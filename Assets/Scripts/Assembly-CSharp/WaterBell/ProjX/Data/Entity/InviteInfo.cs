using System.Collections.Generic;
using Miscmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class InviteInfo : PropertyChangeedObservable
	{
		private Dictionary<long, InviteRewardInfo> invitRewardInfo;

		private Dictionary<long, InviteRewardInfo> beInvitedRewardInfo;

		private long usedCode;

		private string usedCodeOwner;

		public long LastUpdateTime { get; set; }

		public bool HaveInviteReward { get; set; }

		public bool HaveBeInvitedReward { get; set; }

		public Dictionary<long, InviteRewardInfo> InvitRewardInfo
		{
			get
			{
				return null;
			}
		}

		public Dictionary<long, InviteRewardInfo> BeInvitedRewardInfo
		{
			get
			{
				return null;
			}
		}

		public long UsedCode
		{
			get
			{
				return 0L;
			}
		}

		public string UsedCodeOwner
		{
			get
			{
				return null;
			}
		}

		public void UpdateContent(InviteCode info)
		{
		}

		public void UpdateContent(CodeInfo info)
		{
		}

		public void ReceiveInvitorReward(long id)
		{
		}

		public void ReceiveInviterReward(long id)
		{
		}

		private void RefeshHaveNewInvitorReward()
		{
		}

		private void RefeshHaveNewInviterReward()
		{
		}

		public void Dispose()
		{
		}
	}
}
