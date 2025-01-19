using System;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class UILootItemData : UIRawResData
	{
		public int count;

		public bool isFirstGet;

		public ObservableSingleRune runeInfo;

		public RuneUseType runeType;

		public UILootItemData()
		{
		}

		public UILootItemData(RuneItemViewModel _model, RuneUseType _type)
		{
		}

		public UILootItemData(long resID, int lootCount = -1)
		{
		}

		public UILootItemData(GlobalEnum.ResType rType, int lootCount = -1)
		{
		}

		public UILootItemData(long resID, GlobalEnum.ResType rType, int lootCount = -1)
		{
		}

		public UILootItemData(long resID, GlobalEnum.ResType resType, long value, int num)
		{
		}

		public UILootItemData(long resID, GlobalEnum.ResType rType, bool isFirstGet, int lootCount = -1)
		{
		}

		public UILootItemData(ObservableSingleRune rune, RuneUseType _type)
		{
		}
	}
}
