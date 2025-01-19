using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class UserInfoSimple : IUserLevelUpData
	{
		private PlayerSimple playerS;

		private ProgressSimple progressS;

		private List<SingleServantSimple> servantSL;

		private List<LotteryLootData> lootItemDataList;

		public List<LotteryLootData> LootItemDataList
		{
			get
			{
				return null;
			}
		}

		public PlayerSimple PlayerS
		{
			get
			{
				return null;
			}
		}

		public List<SingleServantSimple> ServantSL
		{
			get
			{
				return null;
			}
		}

		public UserInfoSimple()
		{
		}

		public UserInfoSimple(BattleResult battleResult, bool isDebug4Test = false)
		{
		}

		public void Reset()
		{
		}

		private void UpdateMem(BattleResult battleResult)
		{
		}

		public int GetLevel()
		{
			return 0;
		}

		public long GetVit()
		{
			return 0L;
		}

		public long GetVitLimit()
		{
			return 0L;
		}

		public int GetServantLevelLimit()
		{
			return 0;
		}
	}
}
