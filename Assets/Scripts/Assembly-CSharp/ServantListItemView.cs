using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class ServantListItemView : ServantListItemViewViewBase
{
	public UITexture servant_image;

	public UILabel servant_name;

	public UILabel servant_level;

	public UILabel servant_rank;

	public UISprite servant_rank_icon;

	public UILabel weapon_level;

	public Transform weaponItem;

	public UILabel servant_fighting;

	public Transform servant_job;

	public Material materialServantMask;

	public Material materialServantMaskRemoveColor;

	public Transform Stars;

	public GlobalEnum.ServantItemTypes servantState;

	public int sortNum;

	private List<GameObject> weaponList;

	public Transform point;

	public Transform newSprite;

	private static ServantPropertyInfo _info;

	private int _fighting;

	private int _fighting_fastframe;

	private bool isSetInfo;

	private bool _isInit;

	public int fighting
	{
		get
		{
			return 0;
		}
	}

	public override void WeaponLevelChanged(int value)
	{
	}

	public override void Wp3CanComposeChanged(bool value)
	{
	}

	public override void Wp4CanComposeChanged(bool value)
	{
	}

	public override void Weapon3UnlockChanged(bool value)
	{
	}

	public override void Weapon4UnlockChanged(bool value)
	{
	}

	public override void CanPromoteWp3Changed(bool value)
	{
	}

	public override void CanPromoteWp4Changed(bool value)
	{
	}

	public override void Wp3PromoteLvChanged(int value)
	{
	}

	public override void Wp4PromoteLvChanged(int value)
	{
	}

	public override void Wp1PromoteLvChanged(int value)
	{
	}

	public override void Wp2PromoteLvChanged(int value)
	{
	}

	public override void CanPromoteWp1Changed(bool value)
	{
	}

	public override void CanPromoteWp2Changed(bool value)
	{
	}

	public override void FashionChanged(int value)
	{
	}

	public override void Weapon1UnlockChanged(bool value)
	{
	}

	public override void Weapon2UnlockChanged(bool value)
	{
	}

	public override void isExistChanged(bool value)
	{
	}

	public override void Wp1CanComposeChanged(bool value)
	{
	}

	public override void Wp2CanComposeChanged(bool value)
	{
	}

	public override void LvChanged(int value)
	{
	}

	public override void RankChanged(int value)
	{
	}

	public override void StarChanged(int value)
	{
	}

	public override void Awake()
	{
	}

	public override void Start()
	{
	}

	private void ServantClick()
	{
	}

	private long GetWpBySv(long _svID)
	{
		return 0L;
	}

	private void UpdateWeaponLevel(int _level)
	{
	}

	private void UpdateServantLevel(int _level)
	{
	}

	private void UpdateServantRank(int _rank)
	{
	}

	private void UpdateServantStar(int _star)
	{
	}

	private void UpdateServantFighting()
	{
	}

	public void UpdateServantJob()
	{
	}

	public void SetServantInfo()
	{
	}

	public override void Update()
	{
	}

	public void SetCanServantInfo()
	{
	}

	public void SetNotServantInfo()
	{
	}

	public void SetWeaponState()
	{
	}

	private void GetWeaponRare(long id, bool isLock)
	{
	}

	private void SetIconInfo(Transform tran, TypeCsvServantWeapon data, ObservableSingleServant weapons)
	{
	}

	public int GetSortNum()
	{
		return 0;
	}

	private void ReDrwaServantImage()
	{
	}
}
