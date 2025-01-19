namespace WaterBell.ProjX.Playmode
{
	public class ChallengeMode : NormalMode
	{
		public ChallengeData challengeData;

		public long instanceid;

		public ChallengeMode(long instID, MngrCollection mngrc)
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
	}
}
