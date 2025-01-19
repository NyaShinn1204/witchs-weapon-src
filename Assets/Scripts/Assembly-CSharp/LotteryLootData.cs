using System;
using WaterBell.ProjX.View.Panel;

[Serializable]
public class LotteryLootData : UILootItemData
{
	public enum DisplayQuality
	{
		R = 0,
		SR = 1,
		SSR = 2
	}

	public long svID;

	public bool isSvFirstGet;

	public long weaponID;

	public bool isWeaponFirstGet;

	public bool haveKnifeStone;

	public DisplayQuality displayQuality;

	public LotteryLootData(long resID, GlobalEnum.ResType rType, int lootCount = -1)
	{
	}

	public LotteryLootData(long resID, int lootCount = -1)
	{
	}

	public LotteryLootData(GlobalEnum.ResType rType, int lootCount = -1)
	{
	}

	public LotteryLootData(long resID, GlobalEnum.ResType resType, long value, int num, bool isFirstGet = false)
	{
	}

	public LotteryLootData(long svID, bool isSvFirstGet, long weaponID, bool isWeaponFirstGet, bool haveKnifeStone = false)
	{
	}

	private void SetDisplayQuality()
	{
	}
}
