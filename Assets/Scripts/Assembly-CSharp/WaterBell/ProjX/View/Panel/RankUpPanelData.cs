using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class RankUpPanelData : UIDataBase
	{
		public int prevRank;

		public int currentRank;

		public int prevCHP;

		public int currentCHP;

		public int prevCombatScore;

		public int currentCombatScore;

		public List<RankUpSpellData> unlockSpells;

		public string rankIconCurrent;

		public string rankIconPrev;

		public string photo;

		public RankUpPanelData(long servantId, int prevRank, int currentRank, int prevCHP, int currentCHP, int prevCombatScore, int currentCombatScore)
		{
		}
	}
}
