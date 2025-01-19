using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.Playmode;

public class SelectCardsData
{
	public bool showHp;

	public bool showFighting;

	public bool showProperty;

	public bool showAdvance;

	public bool showChallengeRemindText;

	public IPlayMode currmode;

	private long[] servants;

	private long[] weapons;

	private long[] rids;

	public List<ServantDataOnChallleage> restrictedServants;

	public List<long> specialUpSvLists;

	public bool[] canSelect;

	public int SelectCount
	{
		get
		{
			return 0;
		}
	}

	public long[] Servants
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long[] Weapons
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long[] Rids
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsFull
	{
		get
		{
			return false;
		}
	}

	public bool IsOtherServant
	{
		get
		{
			return false;
		}
	}

	protected virtual void GetSelectData()
	{
	}

	private void AddRestrictedServants()
	{
	}

	public ObservableSingleServant GetObservableServant(long _sid)
	{
		return null;
	}

	public MercenaryServant GetMercenary(long _sid, long _rid, int _Mode)
	{
		return null;
	}

	protected bool IsMyServantTeam(long _sid)
	{
		return false;
	}

	protected bool IsRestrict()
	{
		return false;
	}

	public static ObservableServantWeapon GetWeaponData(long _sid, long _wid)
	{
		return null;
	}

	public static MercenaryServant GetMercenaryWeaponData(long _sid, long _rid)
	{
		return null;
	}

	public int GetRuntimeTotalCS()
	{
		return 0;
	}

	public int GetSelectsHp()
	{
		return 0;
	}

	private bool IsUsed(long servantID)
	{
		return false;
	}

	public bool IsSpecialUpSv(long _sid)
	{
		return false;
	}

	public void InitspecialUpSvLists()
	{
	}
}
