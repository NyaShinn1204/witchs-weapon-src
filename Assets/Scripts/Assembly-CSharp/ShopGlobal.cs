using System.Collections.Generic;

public class ShopGlobal
{
	public enum ShopSetType
	{
		item = 0,
		resouce = 1,
		rune = 2,
		daily = 3,
		expediton = 4,
		fashion = 5,
		payGift = 6,
		dayGift = 7,
		weekGift = 8,
		diamondGift = 9,
		activity = 10
	}

	private static ShopGlobal current;

	private const int prefabNumber = 20;

	public const long ItemSetID = 44000001L;

	public const long ResouceSetID = 44000009L;

	public const long RuneSetID = 44000003L;

	public const long DailySetID = 44000004L;

	public const long ExpetionSetID = 44000002L;

	public const long fashionSetID = 44000005L;

	public const long PaySetID = 44000006L;

	public const long PayDaySetID = 44000013L;

	public const long payWeekDaySetID = 44000012L;

	public const long DiamondSetID = 44000007L;

	public const long ActivitySetID = 44000010L;

	protected long[] tabShopIds;

	protected long[] subTabShopIds;

	public Dictionary<long, bool> zhifuObj;

	public Dictionary<long, bool> freshObj;

	public Dictionary<long, bool> helpObj;

	protected long currentID;

	public int PrefabNumber
	{
		get
		{
			return 0;
		}
	}

	public long[] TabShopIds
	{
		get
		{
			return null;
		}
	}

	public long[] SubTabShopIds
	{
		get
		{
			return null;
		}
	}

	public long CurrentID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public bool IsOpenZhifu
	{
		get
		{
			return false;
		}
	}

	public bool IsOpenFresh
	{
		get
		{
			return false;
		}
	}

	public bool IsOpenHelp
	{
		get
		{
			return false;
		}
	}

	public static ShopGlobal GetInstance()
	{
		return null;
	}

	public void InitGlobal()
	{
	}

	private void AddZhifu()
	{
	}

	private void AddFresh()
	{
	}

	private void AddHelp()
	{
	}
}
