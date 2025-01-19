namespace WaterBell.ProjX.Playmode
{
	public class ActivityChallengeMode : NormalMode
	{
		public ChallengeData challengeData;

		public long instanceid;

		public long baseID;

		public int serial;

		public int battleCount;

		public int battleMaxCount;

		public int mode;

		public string extraargu;

		public ActivityChallengeMode(long instID, MngrCollection mngrc, long baseID, int serial, int battleCount, int battleMaxCount, int mode, string extraargu)
			: base(0L, null)
		{
		}

		protected override void Init()
		{
		}

		public void RefreshData()
		{
		}

		public ChallengeData GetRestrictedServants()
		{
			return null;
		}

		public int GetFashionSnForChallengeMode()
		{
			return 0;
		}

		public string GetFashionPrefabNameForChallengeMode()
		{
			return null;
		}

		public override ActionResult IsAble2BeginGame()
		{
			return default(ActionResult);
		}

		protected override void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		protected override void HandleSettlementAnimation()
		{
		}

		public override void OnTryStartBegin()
		{
		}

		public override void OnCombatRestart()
		{
		}
	}
}
