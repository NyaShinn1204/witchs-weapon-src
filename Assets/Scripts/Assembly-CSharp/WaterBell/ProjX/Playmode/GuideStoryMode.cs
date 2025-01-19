using System.Collections;
using System.Diagnostics;

namespace WaterBell.ProjX.Playmode
{
	public class GuideStoryMode : NormalMode
	{
		public GuideStoryMode(long instID, MngrCollection mngrc)
			: base(0L, null)
		{
		}

		protected override void Init()
		{
		}

		protected override void HandleLoadHero()
		{
		}

		protected override void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		public void ParseCardsSetting(string settingStr)
		{
		}

		protected override void HandleSettlementAnimation()
		{
		}

		public override void OnPreCombatBegin()
		{
		}

		[DebuggerHidden]
		private IEnumerator DelayPlayerEnterPlayerEnterAreaEvent()
		{
			return null;
		}
	}
}
