using Levelmod;

namespace WaterBell.ProjX.Playmode
{
	public class ActivityAcceleratePlayMode : NormalMode
	{
		private int useTicketNum;

		public ActivityAcceleratePlayMode(long instID, MngrCollection mngrc)
			: base(0L, null)
		{
		}

		protected override void Init()
		{
		}

		public override ActionResult IsAllowShowSweepGameOnce()
		{
			return default(ActionResult);
		}

		public override ActionResult IsAllowShowSweepGameMultiTime()
		{
			return default(ActionResult);
		}

		public override ActionResult IsAble2SweepGameOnce()
		{
			return default(ActionResult);
		}

		public override ActionResult IsAble2SweepGameMultiTime()
		{
			return default(ActionResult);
		}

		public override ActionResult IsAllow2Fight()
		{
			return default(ActionResult);
		}

		public override void ParseBattleResult(Levelmod.BattleResult result)
		{
		}

		public void SetTicketUseNum(int num)
		{
		}

		public int GetTicketUseNum()
		{
			return 0;
		}

		protected override void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		private void FinishPush()
		{
		}

		public override void OnCombatRestart()
		{
		}

		public override void OnTryStartBegin()
		{
		}
	}
}
