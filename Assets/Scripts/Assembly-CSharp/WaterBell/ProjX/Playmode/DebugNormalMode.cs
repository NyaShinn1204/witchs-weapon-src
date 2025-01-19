using System.Collections;
using System.Diagnostics;
using WaterBell.LevelDesign;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Playmode
{
	public class DebugNormalMode : BasicPlayMode
	{
		private AccountDataRow accDR;

		public DebugNormalMode(MngrCollection mngrc)
		{
		}

		public override void Renew(long instID)
		{
		}

		protected override void Init()
		{
		}

		public void SetInstanceID(long instID)
		{
		}

		public void BindAccInfo(AccountDataRow acc)
		{
		}

		public void StartDebugGameFromLogin(NetMsgSeq.FinishSeqHandler finishHandler)
		{
		}

		[DebuggerHidden]
		private IEnumerator UserLogin(NetMsgSeq.FinishSeqHandler finishHandler)
		{
			return null;
		}

		public void UpdateAndThenLoadin(PlayerCfgSimulator cfgSimulator)
		{
		}

		protected override void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		public override void OnCombatRestart()
		{
		}

		public override void OnLoadOutEnd()
		{
		}
	}
}
