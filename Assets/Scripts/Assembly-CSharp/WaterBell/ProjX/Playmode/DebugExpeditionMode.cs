using System.Collections;
using System.Diagnostics;
using WaterBell.LevelDesign;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Playmode
{
	public class DebugExpeditionMode : ExpeditionMode
	{
		private AccountDataRow accDR;

		public DebugExpeditionMode(MngrCollection mngrc)
			: base(null)
		{
		}

		public override void Renew(long instID)
		{
		}

		protected override void Init()
		{
		}

		public void BindAccInfo(AccountDataRow acc)
		{
		}

		internal void StartDebugGameFromLogin(NetMsgSeq.FinishSeqHandler finishHandler)
		{
		}

		[DebuggerHidden]
		private IEnumerator UserLogin(NetMsgSeq.FinishSeqHandler finishHandler)
		{
			return null;
		}

		public void GoBattle()
		{
		}

		public void SetServantAndWeapon(int i, long sid, long weapon)
		{
		}

		protected override void SelectWeaponByCache(int slotIdx, long svCardID, long rid)
		{
		}

		public void UpdatePlayerAndServant(PlayerCfgSimulator sim, NetMsgSeq.FinishSeqHandler finishHandler)
		{
		}

		public void UpdateExpeditionNodeInfo(string info, NetMsgSeq.FinishSeqHandler handler)
		{
		}

		public void GoChest(NetMsgSeq.FinishSeqHandler handler)
		{
		}

		public void ResetCore(NetMsgSeq.FinishSeqHandler finishHandler)
		{
		}

		private void AddRefreshMsg(NetMsgSeq svUpdateMsgSeq)
		{
		}

		public override void OnLoadOutEnd()
		{
		}
	}
}
